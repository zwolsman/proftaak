using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLibrary;

namespace RFID_Koppelen
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            DatabaseManager.Initialize("sa", "Wachtwoord1", "localhost", "proftaak");
            DatabaseManager.Open();
            LoadPersons();
            Rfid.TagReceivedHandler += TagReceivedHandler;
            Rfid.TagRemoved += TagRemoved;
            Rfid.Start();
            
        }

        private void TagRemoved(object sender, EventArgs eventArgs)
        {
            if (txtRFID.InvokeRequired)
                Invoke(new MethodInvoker(() => txtRFID.Text = string.Empty));
            else
                txtRFID.Text = string.Empty;
        }

        private void TagReceivedHandler(object sender, string s)
        {
            if (txtRFID.InvokeRequired)
                Invoke(new MethodInvoker(() => txtRFID.Text = s));
            else
                txtRFID.Text = s;
        }

        void LoadPersons()
        {
            listPersons.Items.Clear();
            Dictionary<int, Person> persons = new Dictionary<int, Person>();
            foreach (Person p in DatabaseManager.GetItems<Person>())
            {
                if (p.MainTenant == "Y")
                {
                    if (p.Account != null)
                        persons.Add(p.Account.Value, p);
                    
                    if(p.Lease != null)
                        persons.Add(p.Lease.Value+1000, p);
                }
                else
                {
                    if(p.Account != null)
                        persons[p.Account.Value].Persons.Add(p);
                    if (p.Lease != null)
                        persons[p.Lease.Value+1000].Persons.Add(p);
                }
            }

            foreach (KeyValuePair<int, Person> row in persons)
            {
                ListViewGroup group = new ListViewGroup($"Main huurder: {row.Value.Fullname} ({row.Key})");
                ListViewItem item = new ListViewItem(new[]
                {
                    row.Value.ID.ToString(),
                    row.Value.Fullname
                }) {Group = @group};

                listPersons.Groups.Add(group);
                listPersons.Items.Add(item);

                foreach (Person p in row.Value.Persons)
                {
                    item = new ListViewItem(new[]
                    {
                        p.ID.ToString(),
                        p.Fullname
                    }) {Group = @group};
                    listPersons.Items.Add(item);
                }
            }
        }

        private void txtRFID_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = listPersons.SelectedItems.Count > 0 && !string.IsNullOrEmpty(txtRFID.Text);
        }

        private void listPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = listPersons.SelectedItems.Count > 0 && !string.IsNullOrEmpty(txtRFID.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //RFID in RFID table

            if (
                (string)
                    DatabaseManager.QueryFirst(
                        $"SELECT COUNT(*) FROM RFID WHERE Cardnumber = '{txtRFID.Text}'")["Column1"] == "0")
            {
                DatabaseManager.Execute($"INSERT INTO RFID(Cardnumber) VALUES('{txtRFID.Text}')");
            }

            if ((string)
                DatabaseManager.QueryFirst(
                    $"SELECT COUNT(*) FROM RFID_Person WHERE Person = {listPersons.SelectedItems[0].Text}")[
                        "Column1"] == "0")
            {
                DatabaseManager.Execute(
                   $"INSERT INTO RFID_Person(Person, RFID) VALUES({listPersons.SelectedItems[0].Text},'{txtRFID.Text}')");
            }
            else
            {
               
                DatabaseManager.Execute(
                   $"UPDATE RFID_Person SET RFID='{txtRFID.Text}' WHERE Person={listPersons.SelectedItems[0].Text}");
            }
         

        }
    }

    class Person
    {
        public int ID { get; set; }
        public int? Account { get; set; }
        public int? Lease { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Affix { get; set; }
        public string MainTenant { get; set; }
        public string Present { get; set; }

        public string Fullname => string.IsNullOrEmpty(Affix) ? $"{Name} {Surname}" : $"{Name} {Affix} {Surname}";

        public List<Person> Persons = new List<Person>(); 
    }
}
