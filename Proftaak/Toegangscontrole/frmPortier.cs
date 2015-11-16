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
    }
}
