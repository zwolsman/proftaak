using DatabaseLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toegangscontrole.Classes;

namespace Toegangscontrole
{
    public partial class frmBetalingen : Form
    {
        private Evenement evenement;

        public frmBetalingen(Evenement e)
        {
            evenement = e;
            InitializeComponent();
            LoadList();
        }

        private void LoadList()
        {
            int count = 0;
            foreach (Betaling b in DatabaseManager.GetItems<Betaling>(evenement))
            {
                listBetalingen.Items.Add(new ListViewItem(new[]
                {
                    b.Placenumber.ToString(),
                    b.Amount.ToString(),
                    b.Description,
                    b.PaymentDate.ToString("dd-MM-yyyy")
                }));
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            //TODO:
            Reload();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //TODO:
            Reload();
        }

        private void Reload()
        {
            listBetalingen.Items.Clear();
            LoadList();
        }
    }
}
