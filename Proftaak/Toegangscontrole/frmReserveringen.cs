using DatabaseLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toegangscontrole.Classes;

namespace Toegangscontrole
{
    public partial class frmReserveringen : Form
    {
        private const string SQL_GET_INT = "SELECT lp.{0} FROM Lease_Place lp, Person p WHERE (lp.Account=p.Account OR lp.Lease=p.Lease) AND p.ID={1} AND lp.Event={2}";
        private const string SQL_GET_PAYMENT = "SELECT SUM(Amount) AS Betaald FROM Payment WHERE LeasePlace IN ({0})";
        private const string SQL_GET_AMOUNT = "SELECT SUM(Price) AS Bedrag FROM Place WHERE ID IN ({0})";

        private Evenement evenement;
        private Dictionary<int, int> leaseplaceToID = new Dictionary<int, int>();

        public frmReserveringen(Evenement e)
        {
            InitializeComponent();
            evenement = e;
            LoadList();
        }

        private void LoadList()
        {
            //listReservering.Clear();
            foreach (Reservering r in DatabaseManager.GetItems<Reservering>(evenement))
            {
                listReservering.Items.Add(new ListViewItem(new[]
                {
                    r.Name + " " + ((string.IsNullOrEmpty(r.Affix))? r.Surname : r.Affix + " " + r.Surname),
                    r.Bankaccount,
                    r.Place.ToString(),
                    r.Arrival.ToString("dd-MM-yyyy"),
                    r.Departure.ToString("dd-MM-yyyy"),
                    GetToBePaid(r.ID).ToString()
                }));
                if(!leaseplaceToID.ContainsKey(r.Place))
                    leaseplaceToID.Add(r.Place, r.ID_LP);
            }
        }

        private int GetToBePaid(int Person)
        {
            string sql = string.Format(SQL_GET_AMOUNT, string.Format(SQL_GET_INT, "Place", Person, evenement.ID));
            string qry = string.Format(SQL_GET_PAYMENT, string.Format(SQL_GET_INT, "ID", Person, evenement.ID));
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
                return 0;
            }
            int nogTeBetalen;
            if (price["Bedrag"].ToString().Equals(""))
            {
                return 0;
            }
            if (paid["Betaald"].ToString().Equals(""))
                nogTeBetalen = int.Parse(price["Bedrag"].ToString());
            else
                nogTeBetalen = int.Parse(price["Bedrag"].ToString()) - int.Parse(paid["Betaald"].ToString());
            return nogTeBetalen;
        }

        private void btAddPayment_Click(object sender, EventArgs e)
        {
            string bank = listReservering.SelectedItems[0].SubItems[1].Text;
            string bedrag = listReservering.SelectedItems[0].SubItems[5].Text;
            int lp = int.Parse(listReservering.SelectedItems[0].SubItems[2].Text);
            DialogResult result = new frmBetaling(leaseplaceToID[lp], bank, bedrag) { Location = Location, StartPosition = FormStartPosition.CenterParent }.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                listReservering.Items.Clear();
                LoadList();
            }
        }
    }
}
