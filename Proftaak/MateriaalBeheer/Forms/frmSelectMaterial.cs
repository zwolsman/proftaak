using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MateriaalBeheer.Classes;
using DatabaseLibrary;

namespace MateriaalBeheer.Forms
{
    public partial class frmSelectMaterial : Form
    {
        private Dictionary<int, Material> materialen = new Dictionary<int, Material>();
        public Material materiaal { get; private set; }
        public Evenement evenement { get; private set; }

        public frmSelectMaterial(Evenement e)
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
            evenement = e;
            loadMaterials();
        }

        private void loadMaterials()
        {
            materialen.Clear();
            foreach (Material m in DatabaseManager.GetItems<Material>(evenement))
            {
                int index = listMaterial.Items.Add(m.Product);
                materialen.Add(index, m);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (listMaterial.SelectedIndex >= 0)
            {
                DialogResult = DialogResult.OK;
                materiaal = materialen[listMaterial.SelectedIndex];
                Close();
            }
            else
            {
                MessageBox.Show("Selecteer een materiaal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
