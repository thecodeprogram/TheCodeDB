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
    public partial class frmShowImage : Form
    {
        public frmShowImage(string resimYolu)
        {
            InitializeComponent();


            try
            {
                Bitmap bmp = (Bitmap)Image.FromFile(resimYolu);
                this.Width = bmp.Width;
                this.Height = bmp.Height;

                picImage.Image = bmp;

            }
            catch (Exception hata) { MessageBox.Show(hata.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { }
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowImage_Load(object sender, EventArgs e)
        {

        }
    }
}
