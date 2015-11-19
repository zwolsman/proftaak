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
using Reserveer_Systeem;
using DatabaseLibrary;

namespace Toegangscontrole
{
    public partial class frmPortier : Form
    {
        private Classes.Evenement evenement;

        public frmPortier(Classes.Evenement e)
        {
            InitializeComponent();
            evenement = e;
        }

        private void btBetaling_Click(object sender, EventArgs e)
        {
            new frmBetalingen(evenement) { Location = Location, StartPosition = FormStartPosition.CenterParent }.Show(this);
        }

        private void btReservering_Click(object sender, EventArgs e)
        {
            new frmReserveringen(evenement) { Location = Location, StartPosition = FormStartPosition.CenterParent }.Show(this);
        }

        private void btInschrijven_Click(object sender, EventArgs e)
        {
            DatabaseManager.InsertItem(new Lease());
            Lease lease = new Lease() { ID = int.Parse(DatabaseManager.QueryFirst("SELECT MAX(ID) FROM Lease")["Column1"].ToString()) };
            Reserveer_Systeem.frmMain.Lease = lease.ID;
            Reserveer_Systeem.frmMain.SelectedEvenement = new Reserveer_Systeem.Evenement() { ID = evenement.ID, BeginDate = evenement.BeginDate, EndDate = evenement.EndDate};
            frmDatum frmDatum = new frmDatum() { Location = Location, StartPosition = FormStartPosition.CenterParent };
            if (frmDatum.ShowDialog(this) != DialogResult.OK)
            {
                MessageBox.Show("Geen geldige datum ingevoerd. Probeer het opnieuw");
                return;
            }

            frmKaart frmKaart = new frmKaart() { Location = Location, StartPosition = FormStartPosition.CenterParent };
            if (frmKaart.ShowDialog(this) != DialogResult.OK)
            {
                MessageBox.Show("Geen plek gekozen! Probeer het opnieuw.");
                return;
            }
        }

        private void btAanmelden_Click(object sender, EventArgs e)
        {
            while (!Rfid.CheckIn(evenement))
            {
            }
        }
    }
}
