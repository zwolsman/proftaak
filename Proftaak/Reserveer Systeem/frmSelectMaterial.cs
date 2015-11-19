using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLibrary;

namespace Reserveer_Systeem
{
    public partial class frmSelectMaterial : Form
    {
        public Evenement Evenement { get; }

        private List<Material> materials = new List<Material>();
        private List<Item> items = new List<Item>();
        private DateTime from;
        private DateTime till;

        public frmSelectMaterial(Evenement selectedEvenement, DateTime from, DateTime till)
        {
            InitializeComponent();
            Evenement = selectedEvenement;
            this.from = from;
            this.till = till;
            DialogResult = DialogResult.Abort;
            LoadMaterials();
        }

        private void LoadMaterials()
        {
            materials.Clear();
            items.Clear();
            foreach (Material m in DatabaseManager.GetItems<Material>(Evenement))
            {
                foreach (Item i in DatabaseManager.AvailableItems<Item>(m, from, till))
                {
                    m.AddItem(i);
                    items.Add(i);
                }
                if (m.Items.Count > 0)
                {
                    materials.Add(m);
                    ListViewGroup group = new ListViewGroup(m.Product);
                    listMaterials.Groups.Add(group);
                    foreach (Item item in m.Items)
                    {
                        ListViewItem lv = new ListViewItem(new[]
                        {
                        item.Productcode.ToString(),
                        m.Description,
                        (int.Parse(m.PricePD.ToString()) / 1000).ToString("C"),
                        (int.Parse(m.PricePW.ToString()) / 1000).ToString("C")
                        });
                        lv.Group = group;
                        listMaterials.Items.Add(lv);
                    }
                }
            }
        }

        private void btVolgende_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem l in listMaterials.Items)
            {
                if (l.Checked)
                {
                    //TODO: Delete hardcoded RFID
                    //2800c49576
                    ReservationMaterial rm = new ReservationMaterial()
                    {
                        RFID = "2800c49576",
                        Item = int.Parse(l.Text)
                    };
                    DatabaseManager.InsertItem(rm);
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
