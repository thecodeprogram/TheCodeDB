namespace TheCodeDB
{
    partial class frmTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTool));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKomut = new System.Windows.Forms.RichTextBox();
            this.btnCMDBaskaKonumdaBaslat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstKomutlar = new System.Windows.Forms.ListBox();
            this.btnKomutEkle = new System.Windows.Forms.Button();
            this.chkCMDAdmin = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKomut);
            this.groupBox1.Controls.Add(this.btnCMDBaskaKonumdaBaslat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lstKomutlar);
            this.groupBox1.Controls.Add(this.btnKomutEkle);
            this.groupBox1.Controls.Add(this.chkCMDAdmin);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CMD İşlemleri";
            // 
            // txtKomut
            // 
            this.txtKomut.Location = new System.Drawing.Point(6, 225);
            this.txtKomut.Name = "txtKomut";
            this.txtKomut.Size = new System.Drawing.Size(245, 49);
            this.txtKomut.TabIndex = 6;
            this.txtKomut.Text = "";
            // 
            // btnCMDBaskaKonumdaBaslat
            // 
            this.btnCMDBaskaKonumdaBaslat.Location = new System.Drawing.Point(257, 280);
            this.btnCMDBaskaKonumdaBaslat.Name = "btnCMDBaskaKonumdaBaslat";
            this.btnCMDBaskaKonumdaBaslat.Size = new System.Drawing.Size(96, 23);
            this.btnCMDBaskaKonumdaBaslat.TabIndex = 5;
            this.btnCMDBaskaKonumdaBaslat.Text = "CMD Başlat";
            this.btnCMDBaskaKonumdaBaslat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Başka Konum";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lstKomutlar
            // 
            this.lstKomutlar.FormattingEnabled = true;
            this.lstKomutlar.Location = new System.Drawing.Point(6, 19);
            this.lstKomutlar.Name = "lstKomutlar";
            this.lstKomutlar.Size = new System.Drawing.Size(245, 199);
            this.lstKomutlar.TabIndex = 2;
            // 
            // btnKomutEkle
            // 
            this.btnKomutEkle.Location = new System.Drawing.Point(257, 251);
            this.btnKomutEkle.Name = "btnKomutEkle";
            this.btnKomutEkle.Size = new System.Drawing.Size(96, 23);
            this.btnKomutEkle.TabIndex = 1;
            this.btnKomutEkle.Text = "Komut Ekle";
            this.btnKomutEkle.UseVisualStyleBackColor = true;
            // 
            // chkCMDAdmin
            // 
            this.chkCMDAdmin.AutoSize = true;
            this.chkCMDAdmin.Location = new System.Drawing.Point(257, 19);
            this.chkCMDAdmin.Name = "chkCMDAdmin";
            this.chkCMDAdmin.Size = new System.Drawing.Size(96, 17);
            this.chkCMDAdmin.TabIndex = 0;
            this.chkCMDAdmin.Text = "Admin Niyetine";
            this.chkCMDAdmin.UseVisualStyleBackColor = true;
            // 
            // frmTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 331);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTool";
            this.Text = "Tool - Pasif -";
            this.Load += new System.EventHandler(this.frmTool_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstKomutlar;
        private System.Windows.Forms.Button btnKomutEkle;
        private System.Windows.Forms.CheckBox chkCMDAdmin;
        private System.Windows.Forms.Button btnCMDBaskaKonumdaBaslat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox txtKomut;
    }
}