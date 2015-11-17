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

namespace MediaSysteem
{
    public partial class frmStartup : frmBase
    {
        private readonly Dictionary<int, Bitmap> evenementBitmaps = new Dictionary<int, Bitmap>();
        private readonly Dictionary<int, Evenement> evenements = new Dictionary<int, Evenement>();

        public frmStartup()
        {
            InitializeComponent();
            DatabaseManager.Initialize("sa", "Wachtwoord1", "127.0.0.1", "media");
            DatabaseManager.Open();
            
            InitEvents();
            if(comboEvents.Items.Count > 0) { 
                comboEvents.SelectedIndex = 0;
            }
        }

        private void InitEvents()
        {
            foreach (Evenement evenement in DatabaseManager.GetItems<Evenement>("proftaak"))
            {
                
                int index = comboEvents.Items.Add(evenement.Name);
                evenements.Add(index, evenement);
                Task.Run(() => LoadLogo(index, evenement.Logo));
            }
        }

        private void LoadLogo(int id, string url)
        {
            try
            {
                Bitmap logo = new Bitmap(new MemoryStream(new WebClient().DownloadData(url)));
                evenementBitmaps.Add(id, logo);
                evenements[id].LoadedLogo = logo;
                if (id == 0)
                {
                    Globals.SelectedEvenement = evenements[0];
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Oops, couldnt load {url}");
                Debug.WriteLine(ex.Source + ": " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEventInfo.Text = evenements[comboEvents.SelectedIndex].Description;
            //Save it for global usage
            evenements[comboEvents.SelectedIndex].LoadedLogo = evenementBitmaps.ContainsKey(comboEvents.SelectedIndex)
                ? evenementBitmaps[comboEvents.SelectedIndex]
                : null;
            Globals.SelectedEvenement = evenements[comboEvents.SelectedIndex];
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            new frmSignup().Show(this);
        }
    }
}
