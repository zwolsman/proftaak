using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidgets;
using Phidgets.Events;
using DatabaseLibrary;
using System.Collections;
using System.Windows.Forms;

namespace Toegangscontrole.Classes
{
    public static class Rfid
    {
        private const string SQL_GET_INT = "SELECT lp.{0} FROM Lease_Place lp, Person p, RFID_Person rp WHERE (lp.Account = p.Account OR lp.Lease = p.Lease) AND p.ID = rp.Person AND lp.Event = {1} AND rp.RFID = '{2}'";
        private const string SQL_GET_PAYMENT = "SELECT SUM(Amount) AS Betaald FROM Payment WHERE LeasePlace IN ({0})";
        private const string SQL_GET_AMOUNT = "SELECT SUM(Price) AS Bedrag FROM Place WHERE ID IN ({0})";

        private static RFID rfid;
        private static string tag;
        private static bool started = false;

        public static void Start()
        {
            try
            {
                rfid = new RFID();
                tag = string.Empty;
                rfid.Error += new ErrorEventHandler(rfid_Error);
                rfid.Tag += new TagEventHandler(rfid_Tag);
                rfid.TagLost += new TagEventHandler(rfid_TagLost);
                rfid.open();
                rfid.waitForAttachment();
                rfid.Antenna = true;
                rfid.LED = true;
                started = true;
            }
            catch (PhidgetException ex)
            {
                Console.WriteLine(ex.Description);
            }
        }

        static void rfid_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(e.Description);
        }

        static void rfid_Tag(object sender, TagEventArgs e)
        {
            tag = e.Tag;
        }

        static void rfid_TagLost(object sender, TagEventArgs e)
        {
            tag = string.Empty;
        }

        public static Boolean CheckIn(Evenement evenement)
        {
            if (!started)
                Start();
            if (!tag.Equals(string.Empty))
            {
                string t = tag;
                string sql = string.Format(SQL_GET_AMOUNT, string.Format(SQL_GET_INT, "Place", evenement.ID, t));
                string qry = string.Format(SQL_GET_PAYMENT, string.Format(SQL_GET_INT, "ID", evenement.ID, t));
                Hashtable price;
                Hashtable paid;
                try
                {
                    price = DatabaseManager.QueryFirst(sql);
                    paid = DatabaseManager.QueryFirst(qry);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Database Error:" + e.Message);
                    MessageBox.Show("Tag bestaat niet bij dit event", "Onbekende tag", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                int nogTeBetalen;
                if (price["Bedrag"].ToString().Equals(""))
                {

                    return true;
                }
                if (paid["Betaald"].ToString().Equals(""))
                    nogTeBetalen = int.Parse(price["Bedrag"].ToString());
                else
                    nogTeBetalen = int.Parse(price["Bedrag"].ToString()) - int.Parse(paid["Betaald"].ToString());
                frmPayscreen pay = new frmPayscreen(nogTeBetalen, t);
                DialogResult result =pay.ShowDialog();
                if(result == DialogResult.OK || result == DialogResult.Cancel)
                    return true;
            }
            return false;
        }
    }
}
