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
    public partial class frmPicture : Form
    {
        public frmPicture(Image image)
        {
            InitializeComponent();
            pic.Image = image;
        }
    }
}
