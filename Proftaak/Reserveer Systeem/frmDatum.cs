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

namespace Reserveer_Systeem
{
    public partial class frmDatum : Form
    {
        private readonly Dictionary<int, Person> persons = new Dictionary<int, Person>(); 

        public static DateTime From { get; set; }
        public static DateTime Till { get; set; }

        public frmDatum()
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
            dtFrom.MinDate = DateTime.Now;
            dtTill.MinDate = DateTime.Now;
            dtTill.MaxDate = frmMain.SelectedEvenement.EndDate;
        }

        

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            picErrorVoornaam.Visible = string.IsNullOrEmpty(txtVoornaam.Text);
            picErrorAchternaam.Visible = string.IsNullOrEmpty(txtAchternaam.Text);


            if (picErrorVoornaam.Visible || picErrorAchternaam.Visible) //End if there is an empty field
                return;

            Person person = new Person(txtVoornaam.Text, txtAchternaam.Text) {Account = frmMain.Account.ID};
            if (persons.ContainsValue(person))
            {
                picErrorVoornaam.Visible = true;
                picErrorAchternaam.Visible = true;
                return;
            }

            int index = listPersons.Items.Add(person);
            persons.Add(index, person);

        }

        private void txtVoornaam_TextChanged(object sender, EventArgs e)
        {
            picErrorVoornaam.Visible = string.IsNullOrEmpty(txtVoornaam.Text);
            picErrorAchternaam.Visible = string.IsNullOrEmpty(txtAchternaam.Text);
        }

        private void listPersons_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete || listPersons.SelectedIndex == -1) // didnt press delete || nothing is selected
                return;

            int index = listPersons.SelectedIndex;

            persons.Remove(index);
            listPersons.Items.RemoveAt(index);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool errors = false;
            foreach (Person p in persons.Values.Where(p => !DatabaseManager.InsertItem(p)))
            {
                errors = true;
                MessageBox.Show($"Er is iets fout gegaan met het toevoegen van {p}", "Fout", MessageBoxButtons.OK);
            }


            From = dtFrom.Value;
            Till = dtTill.Value;

            DialogResult = !errors ? DialogResult.OK : DialogResult.Abort;
            Close();
        }

        private void dtValueChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = dtTill.Value != dtFrom.Value;
        }
    }
}