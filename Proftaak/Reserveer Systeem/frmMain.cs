﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLibrary;
using Reserveer_Systeem.Classes;


namespace Reserveer_Systeem
{
    public partial class frmMain : Form
    {
        private readonly Dictionary<int, Bitmap> evenementBitmaps = new Dictionary<int, Bitmap>();
        private readonly Dictionary<int, Evenement> evenements = new Dictionary<int, Evenement>();

        public static Account Account;
        public static Evenement SelectedEvenement;
        public static int? Lease = null;
        public frmMain()
        {
            InitializeComponent();
            DatabaseManager.Initialize("sa", "Wachtwoord1", "127.0.0.1", "proftaak");
            DatabaseManager.Open();
            LoadEvents();
        }

        private void LoadEvents()
        {
            foreach (Evenement evenement in DatabaseManager.GetItems<Evenement>())
            {
                int index = listEvents.Items.Add(evenement.Name);
                evenements.Add(index, evenement);
                Task.Run(() => LoadLogo(index, evenement.Logo));
            }
        }

        private void LoadLogo(int id, string url)
        {
            try
            {
                evenementBitmaps.Add(id, new Bitmap(new MemoryStream(new WebClient().DownloadData(url))));
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Oops, couldnt load {url}");
                Debug.WriteLine(ex.Source + ": " + ex.Message);
            }
        }

        private void listEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = listEvents.SelectedIndex != -1;
            btnDatum.Enabled = listEvents.SelectedIndex != -1;

            if (listEvents.SelectedIndex == -1)
                return;

            SelectedEvenement = evenements[listEvents.SelectedIndex];
            lblEventInfo.Text = evenements[listEvents.SelectedIndex].Description;
            picLogo.Image = evenementBitmaps.ContainsKey(listEvents.SelectedIndex)
                ? evenementBitmaps[listEvents.SelectedIndex]
                : null;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if (radioExisting.Checked) //Show login
            {
                frmLogin frmLogin = new frmLogin() { Location = Location, StartPosition = FormStartPosition.CenterParent };

                if (frmLogin.ShowDialog(this) == DialogResult.OK)
                {
                    Account = frmLogin.Account;
                }
                else
                {
                    MessageBox.Show("Geen geldig account, begin opnieuw.");
                    return;
                }
            }
            if (radioNew.Checked) //Show new
            {
                frmNewAccount frmAccount = new frmNewAccount() { Location = Location, StartPosition = FormStartPosition.CenterParent};

                if (frmAccount.ShowDialog(this) == DialogResult.OK)
                {
                    Account = frmAccount.Account;
                }
                else
                {
                    MessageBox.Show("Geen geldig account, begin opnieuw.");
                    return;
                }
            }

            frmDatum frmDatum = new frmDatum() { Location = Location, StartPosition = FormStartPosition.CenterParent };
            if (frmDatum.ShowDialog(this) != DialogResult.OK)
            {
                MessageBox.Show("Geen geldige datum ingevoerd. Probeer het opnieuw");
                return;
            }

            frmKaart frmKaart = new frmKaart() {Location = Location, StartPosition = FormStartPosition.CenterParent };

            if (frmKaart.ShowDialog(this) != DialogResult.OK)
            {
                MessageBox.Show("Geen plek gekozen! Probeer het opnieuw.");
                return;
            }
            frmSelectMaterial frmMaterial = new frmSelectMaterial(SelectedEvenement, frmDatum.From, frmDatum.Till) { Location = Location, StartPosition = FormStartPosition.CenterParent };
            if (frmMaterial.ShowDialog(this) == DialogResult.OK)
            {
                //TODO RICK FIX DEZE SHIZZLE
            }
            try
            {
                if (DatabaseManager.InsertItem(new LeasePlace()
                {
                    Account = Account.ID,
                    Arrival = frmDatum.From,
                    Departure = frmDatum.Till,
                    Event = SelectedEvenement.ID,
                    Place = frmKaart.SpotID
                }))
                {
                    MessageBox.Show("U bent aangemeld! RFID word klaar gezet", "Succes", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
            catch 
            {
                Console.WriteLine("Error insterting item");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmDatum().ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Evenement selectedEvenement = evenements[listEvents.SelectedIndex];
            frmSelectMaterial frmSelectMaterial = new frmSelectMaterial(selectedEvenement, frmDatum.From, frmDatum.Till);

            frmSelectMaterial.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmKaart().ShowDialog(this);
        }
    }
}