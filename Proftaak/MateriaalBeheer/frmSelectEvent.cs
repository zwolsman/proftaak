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

namespace MateriaalBeheer
{
    public partial class frmSelectEvent : Form
    {
        private Dictionary<int, Evenement> evenementen = new Dictionary<int, Evenement>();
        public Evenement evenement { get; private set; }

        public frmSelectEvent()
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
            loadEvents();
        }

        private void loadEvents()
        {
            evenementen.Clear();
            foreach (Evenement e in DatabaseManager.GetItems<Evenement>())
            {
                int index = listEvent.Items.Add(e.Name);
                evenementen.Add(index, e);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (listEvent.SelectedIndex > 0)
            {
                DialogResult = DialogResult.OK;
                evenement = evenementen[listEvent.SelectedIndex];
                Close();
            }
            else
            {
                MessageBox.Show("Selecteer een event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
