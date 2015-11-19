using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void pic_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Image (*.jpg)|*.jpg";

                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    pic.Image.Save(sfd.FileName);
                }
            }
        }
    }
}
