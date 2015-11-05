using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserveer_Systeem
{
    public partial class frmDatum : Form
    {
        private readonly Dictionary<int, Person> persons = new Dictionary<int, Person>(); 

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

            Person person = new Person(txtVoornaam.Text, txtAchternaam.Text);
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
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dtValueChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = dtTill.Value != dtFrom.Value;
        }
    }
}