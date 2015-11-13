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
using MateriaalBeheer.Classes;
using System.Diagnostics;

namespace MateriaalBeheer
{
    public partial class frmRentMaterial : Form
    {
        private Evenement evenement = new Evenement();
        private Dictionary<int, Material> materiaal = new Dictionary<int, Material>();
        private Dictionary<int, Item> item = new Dictionary<int, Item>();
        private Boolean beschikMateriaalweergeven = true;

        public frmRentMaterial()
        {
            DatabaseManager.Initialize("sa", "Wachtwoord1", "127.0.0.1", "proftaak");
            DatabaseManager.Open();
            InitializeComponent();

            while(evenement.ID == -1)
            {
                frmSelectEvent frmSelectEvent = new frmSelectEvent() { Location = Location, StartPosition = FormStartPosition.CenterParent };

                if (frmSelectEvent.ShowDialog(this) == DialogResult.OK)
                {
                    evenement = frmSelectEvent.evenement;
                }
                else
                {
                    MessageBox.Show("Geen geldig evenement, begin opnieuw.");
                }
            }
            LoadMaterial();
        }

        private void LoadMaterial()
        {
            materiaal.Clear();
            foreach (Material m in DatabaseManager.GetItems<Material>())
            {
                int index = listMaterial.Items.Add(m.Product);
                materiaal.Add(index, m);
                LoadItem(m);
            }
        }

        private void LoadItem(Material m)
        {
            materiaal.Clear();
            foreach (Item  i in DatabaseManager.GetItems<Item>())
            {
                m.AddItem(i);
            }
        }

        private void btOverzichtReserveren_Click(object sender, EventArgs e)
        {
            if (beschikMateriaalweergeven)
            {
                //TODO:
            }
            else
            {
                //TODO:
            }
        }

        private void btHuren_Click(object sender, EventArgs e)
        {
            //TODO: check ff of dit kan/logisch is
            #region
            DisableControls(true);
            try
            {
                while (!Rfid.Rent(item[listItem.SelectedIndex], beschikMateriaalweergeven))
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is geen RFID-chip gezien, probeer het opnieuw.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Source + ": " + ex.Message);
            }
            DisableControls(false);
            #endregion
        }

        private void btInnemen_Click(object sender, EventArgs e)
        {
            frmEnterProdCode ProdCode = new frmEnterProdCode() { Location = Location, StartPosition = FormStartPosition.CenterParent };

            if (ProdCode.ShowDialog(this) == DialogResult.OK)
            {
                string productcode = ProdCode.productcode;
                //TODO: Take that productcode off the rentlist
                
                //boolean valid is true if productcode is valid and has been taken off the rentlist
                Boolean valid = true; //true for now
                if (valid)
                    return;
            }
            else if(ProdCode.ShowDialog(this) == DialogResult.Cancel)
            {
                return;
            }
            MessageBox.Show("Geen geldige productcode, probeer opnieuw.");
        }

        private void DisableControls(bool locked)
        {
            foreach (Control control in Controls)
            {
                if (control.InvokeRequired)
                    control.Invoke((MethodInvoker)(() => control.Enabled = !locked));
                else
                    control.Enabled = !locked;
            }
        }
    }
}
