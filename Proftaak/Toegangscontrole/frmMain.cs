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
using Toegangscontrole.Classes;

namespace Toegangscontrole
{
    public partial class frmMain : Form
    {
        private Evenement evenement = new Evenement();
        public frmMain()
        {
            DatabaseManager.Initialize("sa", "Wachtwoord1", "127.0.0.1", "proftaak");
            DatabaseManager.Open();
            InitializeComponent();
            while (evenement.ID == -1)
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
        }

        private void btPortier_Click(object sender, EventArgs e)
        {
            new frmPortier(evenement) { Location = Location, StartPosition = FormStartPosition.CenterParent }.ShowDialog(this);
        }

        private void btCheckIn_Click(object sender, EventArgs e)
        {
            new frmToegangsControle(evenement) { Location = Location, StartPosition = FormStartPosition.CenterParent }.ShowDialog(this);
        }

        private void btAttendence_Click(object sender, EventArgs e)
        {
            new frmPresentieLijst(evenement) { Location = Location, StartPosition = FormStartPosition.CenterParent }.ShowDialog(this);
        }
    }
}
