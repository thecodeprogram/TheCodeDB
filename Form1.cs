using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCodeDB
{
    public partial class Form1 : Form
    {

        private Timer tmr_alwaysSaveContent = null;


        private const string db_base_folder = "database/code";
        private const string db_image_folder = "database/image";
        private const string db_old_files = "database/old";
        private const string db_deleted_files = "database/deleted";

        private int resimCounter = 0;


        public Form1()
        {
            InitializeComponent();

            getCategoriList();

            tmr_alwaysSaveContent = new Timer();
            tmr_alwaysSaveContent.Interval = 5000;
            tmr_alwaysSaveContent.Tick += fnc_updateWithTimer;

        }



        private void getCategoriList()
        {
            cboxCategories.Items.Clear();
            string[] KlasorListesi = Directory.GetDirectories(db_base_folder);
            foreach (string nesne in KlasorListesi)
            {
                DirectoryInfo dir = new DirectoryInfo(nesne);
                string klasor_ad = dir.Name;


                cboxCategories.Items.Add(klasor_ad);
                // seçilen alandaki klasorleri almış olduk
            }

        }

        private void getContentList()
        {

            lstContents.Items.Clear();

            string[] DosyaListesi = Directory.GetFiles(db_base_folder + "/" + cboxCategories.Text);
            foreach (string nesne in DosyaListesi)
            {
                FileInfo dir = new FileInfo(nesne);
                string dosya_ad = dir.Name;

                lstContents.Items.Add(dosya_ad);
                // seçilen alandaki dosyaları almış olduk
            }
        }


        private void btnCreateNewCat_Click(object sender, EventArgs e)
        {
            if (txtNewCatName.Text != "")
            {
                string FilePath = db_base_folder + "/" + txtNewCatName.Text;
                try
                {
                    if (!Directory.Exists(FilePath))
                    {
                        Directory.CreateDirectory(FilePath);
                        MessageBox.Show("Kategori Oluşturuldu");
                        getCategoriList();
                    }
                    else
                    {
                        MessageBox.Show("Bu kategori zaten var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Sistemsel bir hata algılandı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kategori Adını Yazmalısın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboxKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {

            getContentList();

        }

        private void lstKodlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContents.SelectedItem != null)
            {
                StreamReader sr = new StreamReader(db_base_folder + "/" + cboxCategories.Text + "/" + lstContents.Text);
                string oku = sr.ReadToEnd();
                txtCodeContent.Text = oku;
                sr.Close();

                txtContentName.Text = lstContents.Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter temizleyol = new StreamWriter(db_base_folder + "/" + cboxCategories.Text + "/" + txtContentName.Text);
                temizleyol.Write("");
                temizleyol.Write(txtCodeContent.Text);
                temizleyol.Close();
                getContentList();
                MessageBox.Show("Yeni Kayıt eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata) { MessageBox.Show(hata.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            fnc_updateContent(true);
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {

            resimCounter = 0;

            OpenFileDialog resimSec = new OpenFileDialog();
            resimSec.Title = "Görsel Seç";
            resimSec.Filter = "(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.bmp)|*.bmp";
            resimSec.FilterIndex = 1;
            resimSec.Multiselect = false;
            resimSec.ShowDialog();
            foreach (string str in resimSec.FileNames)
            {
                string _fp = db_image_folder + "/" + cboxCategories.Text;
                if (!Directory.Exists(_fp))
                {
                    Directory.CreateDirectory(_fp);
                }

                string[] DosyaListesi = Directory.GetFiles(_fp);


                File.Copy(str, db_image_folder + "/" + cboxCategories.Text + "/" + TCP_TRCharToEN(txtContentName.Text) + "_" + (DosyaListesi.Length + 1).ToString() + Path.GetExtension(str));

                txtCodeContent.Text += " [" + TCP_TRCharToEN(txtContentName.Text) + "_" + (DosyaListesi.Length + 1).ToString() + Path.GetExtension(str) + "]";
            }

        }

        string TCP_TRCharToEN(string text)
        {
            text = text.Replace("Ç", "c");
            text = text.Replace("Ş", "s");
            text = text.Replace("Ö", "o");
            text = text.Replace("Ğ", "g");
            text = text.Replace("Ü", "u");
            text = text.Replace("İ", "i");

            text = text.Replace("ç", "c");
            text = text.Replace("ş", "s");
            text = text.Replace("ö", "o");
            text = text.Replace("ğ", "g");
            text = text.Replace("ü", "u");
            text = text.Replace("ı", "i");

            text = text.Replace(" ", "_");
            text = text.Replace(",", "");
            text = text.Replace("*", "");


            return text;
        }

        private void txtCodeContent_SelectionChanged(object sender, EventArgs e)
        {
            string secilenYer = txtCodeContent.SelectedText.Replace(" ", "");
            if (secilenYer.StartsWith("[") && secilenYer.EndsWith("]"))
            {
                //    MessageBox.Show("Resim Dosyası seçtin");
                btnOpenSelectedImage.Left = Cursor.Position.X - this.Left;
                btnOpenSelectedImage.Top = Cursor.Position.Y - this.Top;

                btnOpenSelectedImage.Visible = true;

            }
        }

        private void txtCodeContent_Click(object sender, EventArgs e)
        {
            if (txtCodeContent.SelectedText == "")
            {
                btnOpenSelectedImage.Visible = false;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            btnOpenSelectedImage.Visible = false;
        }

        private void btnOpenSelectedImage_Click(object sender, EventArgs e)
        {
            string _dy = db_image_folder + "/" + cboxCategories.Text + "/" + txtCodeContent.SelectedText.Replace("[", "").Replace("]", "").Replace(" ", "");
            frmShowImage fShow = new frmShowImage(_dy);
            fShow.Show(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bu İçeriği Geri Dönüşüm Kutusuna gönderecenmi ?", "Silecenmi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (lstContents.SelectedItem != null)
                {
                    try
                    {
                        string _fp = db_deleted_files + "/" + cboxCategories.Text;
                        if (!Directory.Exists(_fp))
                        {
                            Directory.CreateDirectory(_fp);
                        }

                        File.Move(db_base_folder + "/" + cboxCategories.Text + "/" + lstContents.Text, db_deleted_files + "/" + cboxCategories.Text + "/" + lstContents.Text.Replace(".txt", "") + "_" + DateTime.Now.ToString("ddMMyyyy_HHmm") + ".txt");
                        MessageBox.Show("Dosya başarılı bir şekilde geri dönüşüme gönderildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getContentList();
                    }
                    catch (Exception hata) { MessageBox.Show(hata.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    finally { }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int findex = lstContents.FindString(txtSearch.Text);

            if (findex > -1)
            {
                lstContents.SetSelected(findex, true);
            }
            else
            {
                lstContents.ClearSelected();
            }


        }

        private void fnc_updateContent(bool saveOld)
        {
            try
            {
                int _selectedContentIndex = lstContents.SelectedIndex;
                int line, index;
                index = txtCodeContent.SelectionStart;
                line = txtCodeContent.GetLineFromCharIndex(index);

                string _fp = db_old_files + "/" + cboxCategories.Text;
                if (!Directory.Exists(_fp))
                {
                    Directory.CreateDirectory(_fp);
                }

                if (saveOld == true)
                {
                    File.Move(db_base_folder + "/" + cboxCategories.Text + "/" + lstContents.Text, db_old_files + "/" + cboxCategories.Text + "/" + lstContents.Text.Replace(".txt", "") + "_" + txtContentName.Text + "_" + DateTime.Now.ToString("_ddMMyyyy_HHmmss") + ".txt");
                }

                File.WriteAllText(db_base_folder + "/" + cboxCategories.Text + "/" + txtContentName.Text, "");
                File.WriteAllText(db_base_folder + "/" + cboxCategories.Text + "/" + txtContentName.Text, txtCodeContent.Text);
                getContentList();

                if(saveOld)
                    MessageBox.Show("Güncelleme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lstContents.SelectedIndex = _selectedContentIndex;
                txtCodeContent.SelectionStart = txtCodeContent.Text.Length - 1;
                fnc_setLastProcessText( "Güncelleme Başarılı...\nİşlem Saati : " + DateTime.Now.ToString("HH:mm:ss") );
            }
            catch (Exception hata) { MessageBox.Show(hata.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { }
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            frmTool t = new frmTool();
            t.Show();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Control && e.KeyCode == Keys.S)       // Ctrl-S Save
            {
                fnc_updateContent(false);
                e.SuppressKeyPress = true;
            }
            else if (e.Control &&  e.KeyData == Keys.Tab )
            {
                e.SuppressKeyPress = true;
                txtCodeContent.Text += "\t";
            }
        }

        private void txtSearchInContent_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchInContent.Text != "")
            {
                int _aramaLocation = txtCodeContent.Text.ToLower().IndexOf(txtSearchInContent.Text.ToLower());
                if (_aramaLocation > -1)
                {
                    /*
                    txtCodeContent.SelectionStart = _aramaLocation;
                    txtCodeContent.SelectionLength = txtSearchInContent.Text.Length;
                    */
                    string[] searchTerms = new[] { txtSearchInContent.Text.ToString() };

                    if (txtCodeContent.Text != string.Empty)
                    {
                        string text = txtCodeContent.Text;
                        txtCodeContent.Text = "";
                        txtCodeContent.Text = text;
                        foreach (Match m in new Regex(string.Join("|", searchTerms.Select(t => t.Replace("|", "\\|")))).Matches(txtCodeContent.Text))
                        {
                            txtCodeContent.Select(m.Index, m.Length);
                            txtCodeContent.SelectionColor = Color.Blue;
                        }
                    }
                }
            }
        }

        private void fnc_updateWithTimer(object sender, EventArgs e)
        {
            if (txtCodeContent.Text != "" && txtContentName.Text != "" && lstContents.SelectedItem != null && cboxCategories.SelectedItem != null)
            {
                fnc_updateContent(false);
            }
            else
            {
                fnc_setLastProcessText("Başarısız Güncelleme Denemesi... ");
            }
        }

        private void fnc_setLastProcessText(string _text = "")
        {
            //lblLastProcess.Text = _text;
        }

        private void btmAboutMe_Click(object sender, EventArgs e)
        {
            frmHakkimda frm = new frmHakkimda();
            frm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstContents.ClearSelected();
            txtCodeContent.Text = "";
            txtSearch.Text = "";
            txtContentName.Text = "";
            txtSearchInContent.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
