﻿using System;
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

namespace MateriaalBeheer //TODO: testen
{
    public partial class frmModifyItem : Form
    {
        private readonly Dictionary<int, Evenement> evenementen = new Dictionary<int, Evenement>();
        private Dictionary<int, Material> materials = new Dictionary<int, Material>();
        private Dictionary<int, Item> items = new Dictionary<int, Item>();
        private Evenement selectedEvenement;
        private Material selectedMaterial;
        private Item selectedItem;

        public frmModifyItem()
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
                LoadMaterials(e);
            }
        }

        private void LoadMaterials(Evenement e)
        {
            foreach (Material m in DatabaseManager.GetItems<Material>(e))
            {
                e.AddMaterial(m);
                LoadItems(m);
            }
        }

        private void LoadItems(Material m)
        {
            foreach (Item i in DatabaseManager.GetItems<Item>(m))
            {
                m.AddItem(i);
            }
        }

        private void listEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            if (listEvent.SelectedIndex == -1)
                return;
            materials.Clear();
            selectedEvenement = evenementen[listEvent.SelectedIndex];
            foreach (Material m in selectedEvenement.material)
            {
                int index = listMaterial.Items.Add(m.Product);
                materials.Add(index, m);
            }
        }

        private void listMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearItems();
            if (listMaterial.SelectedIndex == -1)
                return;
            selectedMaterial = materials[listMaterial.SelectedIndex];
            txtProduct.Text = selectedMaterial.Product;
            txtDescription.Text = selectedMaterial.Description;
            txtPricePD.Text = selectedMaterial.PricePD.ToString();
            txtPricePW.Text = selectedMaterial.PricePW.ToString();
            foreach  (Item i in selectedMaterial.Items)
            {
                int index = listItem.Items.Add(i.Productcode);
                items.Add(index, i);
            }
        }

        private void listItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listItem.SelectedIndex == -1)
                return;
            selectedItem = items[listItem.SelectedIndex];
            txtProductcode.Text = selectedItem.Productcode.ToString();
        }

        private void btVerwijderen_Click(object sender, EventArgs e)
        {
            if (selectedEvenement == null)
            {
                MessageBox.Show("Geen evenement geselecteerd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedMaterial == null)
            {
                MessageBox.Show("Geen materiaal geselecteerd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DatabaseManager.DeleteItem(selectedMaterial);
            LoadMaterials(selectedEvenement);
        }

        private void btWijzigen_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPricePD.Text, @"^\d+$"))
            {
                MessageBox.Show("Prijs per dag is geen integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(txtPricePW.Text, @"^\d+$"))
            {
                MessageBox.Show("Prijs per week is geen integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedEvenement == null)
            {
                MessageBox.Show("Geen evenement geselecteerd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Material m = selectedMaterial;
            m.Product = txtProduct.Text;
            m.Description = txtDescription.Text;
            m.PricePD = int.Parse(txtPricePD.Text);
            m.PricePW = int.Parse(txtPricePW.Text);
            DatabaseManager.UpdateItem(m);
        }

        private void btToevoegen_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPricePD.Text, @"^\d+$"))
            {
                MessageBox.Show("Prijs per dag is geen integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(txtPricePW.Text, @"^\d+$"))
            {
                MessageBox.Show("Prijs per week is geen integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedEvenement == null)
            {
                MessageBox.Show("Geen evenement geselecteerd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Material m = new Material
            {
                Product = txtProduct.Text,
                Description = txtDescription.Text,
                PricePD = int.Parse(txtPricePD.Text),
                PricePW = int.Parse(txtPricePW.Text),
                Event = selectedEvenement.ID
            };
            DatabaseManager.InsertItem(m);
            selectedEvenement.AddMaterial(m);
            int index = listMaterial.Items.Add(m.Product);
            materials.Add(index, m);
        }

        private void Clear()
        {
            selectedEvenement = null;
            selectedMaterial = null;
            selectedItem = null;
            txtProduct.Clear();
            listMaterial.Items.Clear();
            listItem.Items.Clear();
            txtDescription.Clear();
            txtPricePD.Clear();
            txtPricePW.Clear();
            txtProductcode.Clear();
        }

        private void ClearItems()
        {
            selectedMaterial = null;
            selectedItem = null;
            listItem.Items.Clear();
            txtProductcode.Clear();
        }

        private void btItemVerwijderen_Click(object sender, EventArgs e)
        {
            if (selectedEvenement == null)
            {
                MessageBox.Show("Geen evenement geselecteerd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedMaterial == null)
            {
                MessageBox.Show("Geen materiaal geselecteerd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DatabaseManager.DeleteItem(selectedItem);
            LoadItems(selectedMaterial);
        }

        private void btItemWijzigen_Click(object sender, EventArgs e)
        {
            if (selectedEvenement == null)
            {
                MessageBox.Show("Geen evenement geselecteerd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedMaterial == null)
            {
                MessageBox.Show("Geen materiaal geselecteerd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Item i = selectedItem;
            i.Productcode = int.Parse(txtProductcode.Text);
            DatabaseManager.UpdateItem(i);
        }

        private void btItemToevoegen_Click(object sender, EventArgs e)
        {
            if (selectedEvenement == null)
            {
                MessageBox.Show("Geen evenement geselecteerd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedMaterial == null)
            {
                MessageBox.Show("Geen materiaal geselecteerd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Item i = new Item
            {
                Material = selectedMaterial.ID,
                Productcode = int.Parse(txtProductcode.Text)
            };
            DatabaseManager.InsertItem(i);
            selectedMaterial.AddItem(i);
            int index = listItem.Items.Add(i.Productcode);
            items.Add(index, i);
        }
    }
}