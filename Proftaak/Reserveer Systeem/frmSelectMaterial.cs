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
        public List<Material> Materials => new List<Material>(materials);

        private List<Material> materials = new List<Material>();

        public frmSelectMaterial(Evenement selectedEvenement)
        {
            InitializeComponent();
            Evenement = selectedEvenement;
            LoadMaterials();
        }

        private void LoadMaterials()
        {
            materials.Clear();
            materials.AddRange(DatabaseManager.GetItems<Material>(Evenement));
            foreach (Material m in materials)
            {
                listMaterials.Items.Add(new ListViewItem(new[]
                {
                    m.Product,
                    m.Description,
                    m.PricePD.ToString(),
                    m.PricePW.ToString(),
                    "True"
                }));
            }
        }

       
    }
}
