using System;
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


namespace Reserveer_Systeem
{
    public partial class frmMain : Form
    {
        private readonly Dictionary<int, Bitmap> evenementBitmaps = new Dictionary<int, Bitmap>();
        private readonly Dictionary<int, Evenement> evenements = new Dictionary<int, Evenement>();

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
            }
        }

        private void listEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = listEvents.SelectedIndex != -1;
            btnDatum.Enabled = listEvents.SelectedIndex != -1;

            if (listEvents.SelectedIndex == -1)
                return;

            lblEventInfo.Text = evenements[listEvents.SelectedIndex].Description;
            picLogo.Image = evenementBitmaps.ContainsKey(listEvents.SelectedIndex)
                ? evenementBitmaps[listEvents.SelectedIndex]
                : null;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            new frmNewAccount().ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmDatum().ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Evenement selectedEvenement = evenements[listEvents.SelectedIndex];
            frmSelectMaterial frmSelectMaterial = new frmSelectMaterial(selectedEvenement);

            frmSelectMaterial.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmKaart().ShowDialog(this);
        }
    }
}