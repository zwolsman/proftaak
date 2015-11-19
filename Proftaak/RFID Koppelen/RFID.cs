using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLibrary;
using Phidgets;
using Phidgets.Events;

namespace RFID_Koppelen
{
    public static class Rfid
    {
        private const string SQL_GET_INT = "SELECT lp.{0} FROM Lease_Place lp, Person p, RFID_Person rp WHERE (lp.Account = p.Account OR lp.Lease = p.Lease) AND p.ID = rp.Person AND lp.Event = {1} AND rp.RFID = '{2}'";
        private const string SQL_GET_PAYMENT = "SELECT SUM(Amount) AS Betaald FROM Payment WHERE LeasePlace IN ({0})";
        private const string SQL_GET_AMOUNT = "SELECT SUM(Price) AS Bedrag FROM Place WHERE ID IN ({0})";

        private static RFID rfid;
        private static string tag;
        private static bool started = false;

        public static EventHandler<string> TagReceivedHandler;
        public static EventHandler TagRemoved;

        public static void Start()
        {
            try
            {
                rfid = new RFID();
                tag = string.Empty;
                rfid.Error += rfid_Error;
                rfid.Tag += rfid_Tag;
                rfid.TagLost += rfid_TagLost;
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
            TagReceivedHandler?.Invoke(new object(), e.Tag);
        }

        static void rfid_TagLost(object sender, TagEventArgs e)
        {
            tag = string.Empty;
            TagRemoved?.Invoke(null, EventArgs.Empty);
        }
    }
}
