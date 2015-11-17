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
    public partial class frmPortier : Form
    {
        private Evenement evenement;

        public frmPortier(Evenement e)
        {
            InitializeComponent();
            evenement = e;
        }

        private void btBetaling_Click(object sender, EventArgs e)
        {

        }

        private void btReservering_Click(object sender, EventArgs e)
        {

        }

        private void btInschrijven_Click(object sender, EventArgs e)
        {

        }

        private void btAanmelden_Click(object sender, EventArgs e)
        {
            while (!Rfid.CheckIn(evenement))
            {
            }
        }
    }
}
