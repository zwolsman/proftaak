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

namespace EvenementBeheerSysteem.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            Task.Run(() => LoadEvents());
        }

        private void LoadEvents()
        {
            listEvents.Items.Clear();
            foreach (Evenement evenement in DatabaseManager.GetItems<Evenement>())
            {
                if (listEvents.InvokeRequired)
                {
                    listEvents.Invoke((MethodInvoker) delegate
                    {
                        listEvents.Items.Add(
                            new ListViewItem(new[] {evenement.ID.ToString(), evenement.Name, evenement.Location})
                            {
                                Tag = evenement
                            }
                            );
                    });
                }
                else
                {
                    listEvents.Items.Add(
                        new ListViewItem(new[] {evenement.ID.ToString(), evenement.Name, evenement.Location})
                        {
                            Tag = evenement
                        }
                        );
                }
            }
        }

        private void listEvents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listEvents.SelectedItems.Count == 0)
                return;

            ListViewItem selecteListViewItem = listEvents.SelectedItems[0];
            Evenement evenement = selecteListViewItem.Tag as Evenement;

            groupEvenement.Text = $"Wijzig evenement - ID: {evenement.ID}";
            txtNaam.Text = evenement.Name;
            txtLocatie.Text = evenement.Location;
            txtLogo.Text = evenement.Logo;
            txtCampingmap.Text = evenement.Campingmap;
            dtBegin.Value = evenement.BeginDate;
            dtEind.Value = evenement.EndDate;
            txtDescription.Text = evenement.Description;
            btnSave.Text = "Opslaan";
            btnCancel.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Hide();
            groupEvenement.Text = "Nieuw Evenement";
            txtNaam.Clear();
            txtLocatie.Clear();
            txtLogo.Clear();
            txtCampingmap.Clear();
            dtBegin.Value = DateTime.Now;
            dtEind.Value = DateTime.Now;
            txtDescription.Clear();
            btnSave.Text = "Aanmaken";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Evenement evenement = new Evenement
            {
                BeginDate = dtBegin.Value,
                Campingmap = txtCampingmap.Text,
                Description = txtDescription.Text,
                EndDate = dtEind.Value,
                Location = txtLocatie.Text,
                Name = txtNaam.Text,
                Logo = txtLogo.Text
            };
            if (btnSave.Text == "Aanmaken")
            {
                DatabaseManager.InsertItem(evenement);
            }
            else
            {
                if (listEvents.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selecteer het event die ge-update moet worden");
                    return;
                }


                evenement.ID = ((Evenement) listEvents.SelectedItems[0].Tag).ID;
                DatabaseManager.UpdateItem(evenement);
            }
            LoadEvents();
        }

        private void listEvents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
                return;
            //Delete key is pressed
            if (listEvents.SelectedItems.Count == 0)
                return;

            foreach (ListViewItem selecteListViewItem in listEvents.SelectedItems)
            {
                Evenement evenement = selecteListViewItem.Tag as Evenement;
                DatabaseManager.DeleteItem(evenement);
            }
            LoadEvents();
        }
    }
}