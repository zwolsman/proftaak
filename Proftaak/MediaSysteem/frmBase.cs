using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaSysteem
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();

            if (Globals.SelectedEvenement != null)
            {
                lblEventName.Text = Globals.SelectedEvenement.Name;
                picLogo.Image = Globals.SelectedEvenement.LoadedLogo;
            }
            Globals.EvenementChanged += delegate(object sender, Evenement evenement)
            {
                lblEventName.Text = evenement.Name;
                picLogo.Image = evenement.LoadedLogo;
            };
        }
    }
}
