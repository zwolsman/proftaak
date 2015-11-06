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
using System.Text.RegularExpressions;

namespace MateriaalBeheer
{
    public partial class frmModifyMaterial : Form
    {
        private readonly Dictionary<int, Evenement> evenementen = new Dictionary<int, Evenement>();
        private Dictionary<int, Material> materials = new Dictionary<int, Material>();

        public frmModifyMaterial()
        {
            InitializeComponent();
            LoadEvents();
        }

        private void LoadEvents()
        {
            foreach (Evenement e in DatabaseManager.GetItems<Evenement>())
            {
                int index = listEvent.Items.Add(e.Name);
                evenementen.Add(index, e);
                e.material.AddRange(DatabaseManager.GetItems<Material>(e));
            }
        }

        private void listEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            listMaterial.Items.Clear();
            if (listEvent.SelectedIndex == -1)
                return;
            materials.Clear();
            foreach  (Material m in evenementen[listEvent.SelectedIndex].material)
            {
                int index = listMaterial.Items.Add(m.Product);
                materials.Add(index, m);
            }
        }

        private void listMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMaterial.SelectedIndex == -1)
                return;
            Material m = materials[listMaterial.SelectedIndex];
            tbProduct.Text = m.Product;
            tbDescription.Text = m.Description;
            tbPricePD.Text = m.PricePD.ToString();
            tbPricePW.Text = m.PricePW.ToString();
        }

        private void btVerwijderen_Click(object sender, EventArgs e)
        {
            DatabaseManager.DeleteItem(materials[listMaterial.SelectedIndex]);
            int index = listEvent.SelectedIndex;
            LoadEvents();
            listEvent.SelectedIndex = index;
        }

        private void btWijzigen_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbPricePD.Text, @"^\d+$"))
            {
                MessageBox.Show("Prijs per dag is geen integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(tbPricePW.Text, @"^\d+$"))
            {
                MessageBox.Show("Prijs per week is geen integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Material m = materials[listMaterial.SelectedIndex];
            m.Product = tbProduct.Text;
            m.Description = tbDescription.Text;
            m.PricePD = int.Parse(tbPricePD.Text);
            m.PricePW = int.Parse(tbPricePW.Text);
            DatabaseManager.UpdateItem(m);
        }

        private void btToevoegen_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbPricePD.Text, @"^\d+$"))
            {
                MessageBox.Show("Prijs per dag is geen integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(tbPricePW.Text, @"^\d+$"))
            {
                MessageBox.Show("Prijs per week is geen integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Material m = new Material();
            m.Product = tbProduct.Text;
            m.Description = tbDescription.Text;
            m.PricePD = int.Parse(tbPricePD.Text);
            m.PricePW = int.Parse(tbPricePW.Text);
            DatabaseManager.InsertItem(m);
            evenementen[listEvent.SelectedIndex].AddMaterial(m);
            int index = listMaterial.Items.Add(m.Product);
            materials.Add(index, m);
        }
    }
}
