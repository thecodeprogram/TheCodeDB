using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCodeDB
{
    public partial class frmHakkimda : Form
    {
        public frmHakkimda()
        {
            InitializeComponent();

            Bitmap bmp = new Bitmap("image/tcp_icon.png");
            picIcon.Image = bmp;

        }

        private void frmHakkimda_Load(object sender, EventArgs e)
        {

        }

        private void lblAboutText_Click(object sender, EventArgs e)
        {

        }
    }
}
