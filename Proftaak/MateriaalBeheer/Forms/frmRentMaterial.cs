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
using System.Diagnostics;

namespace MateriaalBeheer.Forms
{
    public partial class frmRentMaterial : Form //TODO: testen
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
            AvailableItems();
        }

        private void AvailableItems()
        {
            Clear();
            foreach (Material m in DatabaseManager.GetItems<Material>(evenement))
            {
                foreach (Item i in DatabaseManager.AvailableItems<Item>(m, beschikMateriaalweergeven))
                {
                    m.AddItem(i);
                }
                if (m.Items.Count > 0)
                {
                    int index = listMaterial.Items.Add(m.Product);
                    materiaal.Add(index, m);
                }
            }
        }

        private void LoadItems()
        {
            ClearItems();
            foreach (Item i in materiaal[listMaterial.SelectedIndex].Items)
            {
                int index = listItem.Items.Add(i.Productcode);
                item.Add(index, i);
            }
        }

        private void Clear()
        {
            listMaterial.Items.Clear();
            materiaal.Clear();
            ClearItems();
        }

        private void ClearItems()
        {
            listItem.Items.Clear();
            item.Clear();
        }

        private void btOverzichtReserveren_Click(object sender, EventArgs e)
        {
            if (beschikMateriaalweergeven)
            {
                beschikMateriaalweergeven = !beschikMateriaalweergeven;
                AvailableItems();
            }
            else
            {
                beschikMateriaalweergeven = !beschikMateriaalweergeven;
                AvailableItems();
            }
        }

        private void btHuren_Click(object sender, EventArgs e)
        {
            //TODO: check ff of dit kan/logisch is
            if (listMaterial.SelectedIndex == -1)
            {
                MessageBox.Show("Geen materiaal geselecteerd.");
                return;
            }
            if (listItem.SelectedIndex == -1)
            {
                MessageBox.Show("Geen item geselecteerd.");
                return;
            }
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
                if (!System.Text.RegularExpressions.Regex.IsMatch(productcode, @"^\d+$"))
                {
                    MessageBox.Show("Productcode is geen integer, probeer opnieuw.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Item i = new Item()
                {
                    Productcode = int.Parse(productcode)
                };
                Item item = DatabaseManager.ContainsItem<Item>(i, "Productcode");
                if (item == default(Item))
                {
                    MessageBox.Show("Productcode bestaat niet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LeaseMaterial lm = new LeaseMaterial()
                {
                    Item = item.ID
                };
                LeaseMaterial lease = DatabaseManager.ContainsLease<LeaseMaterial>(lm, "Item");
                if (lease == default(LeaseMaterial))
                {
                    MessageBox.Show("Item is niet verhuurd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ReturnMaterial rm = new ReturnMaterial()
                {
                    RFID = lease.RFID,
                    Item = lease.Item
                };
                int renttime = (rm.ReturnDate - lease.LeaseDate).Days;
                Material m = new Material()
                {
                    ID = item.Material
                };
                Material mat = DatabaseManager.ContainsItem<Material>(m, "ID");
                int price = 0;
                if(mat.PricePW > 0)
                {
                    price += (renttime / 7) * mat.PricePW + (renttime % 7) * mat.PricePD;
                }
                else
                {
                    price += renttime * mat.PricePD;
                }
                frmPayscreen payscreen = new frmPayscreen(renttime, price, rm.RFID) { Location = Location, StartPosition = FormStartPosition.CenterParent };
                if(payscreen.ShowDialog(this) == DialogResult.OK)
                {
                    if (DatabaseManager.InsertItem<ReturnMaterial>(rm))
                    {
                        MessageBox.Show("Gelukt!");
                        return;
                    }
                }
                else if(payscreen.ShowDialog(this) == DialogResult.Cancel)
                    return;
                MessageBox.Show("Het is helaas niet gelukt. Probeer opnieuw.");
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

        private void listMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMaterial.SelectedIndex == -1)
                return;
            LoadItems();
        }
    }
}
