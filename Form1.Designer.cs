namespace TheCodeDB
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateNewCat = new System.Windows.Forms.Button();
            this.txtNewCatName = new System.Windows.Forms.TextBox();
            this.cboxCategories = new System.Windows.Forms.ComboBox();
            this.lstContents = new System.Windows.Forms.ListBox();
            this.txtCodeContent = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtContentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.btnOpenSelectedImage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTool = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchInContent = new System.Windows.Forms.TextBox();
            this.btmAboutMe = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // btnCreateNewCat
            // 
            this.btnCreateNewCat.Location = new System.Drawing.Point(110, 35);
            this.btnCreateNewCat.Name = "btnCreateNewCat";
            this.btnCreateNewCat.Size = new System.Drawing.Size(147, 23);
            this.btnCreateNewCat.TabIndex = 1;
            this.btnCreateNewCat.Text = "Create new Category";
            this.btnCreateNewCat.UseVisualStyleBackColor = true;
            this.btnCreateNewCat.Click += new System.EventHandler(this.btnCreateNewCat_Click);
            // 
            // txtNewCatName
            // 
            this.txtNewCatName.Location = new System.Drawing.Point(96, 9);
            this.txtNewCatName.Name = "txtNewCatName";
            this.txtNewCatName.Size = new System.Drawing.Size(161, 20);
            this.txtNewCatName.TabIndex = 2;
            // 
            // cboxCategories
            // 
            this.cboxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategories.FormattingEnabled = true;
            this.cboxCategories.Location = new System.Drawing.Point(13, 64);
            this.cboxCategories.Name = "cboxCategories";
            this.cboxCategories.Size = new System.Drawing.Size(244, 21);
            this.cboxCategories.TabIndex = 3;
            this.cboxCategories.SelectedIndexChanged += new System.EventHandler(this.cboxKategoriler_SelectedIndexChanged);
            // 
            // lstContents
            // 
            this.lstContents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstContents.FormattingEnabled = true;
            this.lstContents.Location = new System.Drawing.Point(13, 92);
            this.lstContents.Name = "lstContents";
            this.lstContents.Size = new System.Drawing.Size(244, 355);
            this.lstContents.TabIndex = 4;
            this.lstContents.SelectedIndexChanged += new System.EventHandler(this.lstKodlar_SelectedIndexChanged);
            // 
            // txtCodeContent
            // 
            this.txtCodeContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeContent.Location = new System.Drawing.Point(264, 35);
            this.txtCodeContent.Name = "txtCodeContent";
            this.txtCodeContent.Size = new System.Drawing.Size(928, 548);
            this.txtCodeContent.TabIndex = 5;
            this.txtCodeContent.Text = "";
            this.txtCodeContent.SelectionChanged += new System.EventHandler(this.txtCodeContent_SelectionChanged);
            this.txtCodeContent.Click += new System.EventHandler(this.txtCodeContent_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(142, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Add New";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(19, 480);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtContentName
            // 
            this.txtContentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContentName.Location = new System.Drawing.Point(356, 13);
            this.txtContentName.Name = "txtContentName";
            this.txtContentName.Size = new System.Drawing.Size(836, 20);
            this.txtContentName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Content Name";
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResimEkle.Location = new System.Drawing.Point(142, 509);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(116, 23);
            this.btnResimEkle.TabIndex = 10;
            this.btnResimEkle.Text = "Add Image";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // btnOpenSelectedImage
            // 
            this.btnOpenSelectedImage.Location = new System.Drawing.Point(1117, 560);
            this.btnOpenSelectedImage.Name = "btnOpenSelectedImage";
            this.btnOpenSelectedImage.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSelectedImage.TabIndex = 11;
            this.btnOpenSelectedImage.Text = "Show Image";
            this.btnOpenSelectedImage.UseVisualStyleBackColor = true;
            this.btnOpenSelectedImage.Visible = false;
            this.btnOpenSelectedImage.Click += new System.EventHandler(this.btnOpenSelectedImage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(19, 509);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Content";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Location = new System.Drawing.Point(66, 454);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Search :";
            // 
            // btnTool
            // 
            this.btnTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTool.Location = new System.Drawing.Point(19, 588);
            this.btnTool.Name = "btnTool";
            this.btnTool.Size = new System.Drawing.Size(62, 23);
            this.btnTool.TabIndex = 15;
            this.btnTool.Text = "Tool";
            this.btnTool.UseVisualStyleBackColor = true;
            this.btnTool.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 594);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Search In Content:";
            // 
            // txtSearchInContent
            // 
            this.txtSearchInContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchInContent.Location = new System.Drawing.Point(377, 591);
            this.txtSearchInContent.Name = "txtSearchInContent";
            this.txtSearchInContent.Size = new System.Drawing.Size(815, 20);
            this.txtSearchInContent.TabIndex = 17;
            this.txtSearchInContent.TextChanged += new System.EventHandler(this.txtSearchInContent_TextChanged);
            // 
            // btmAboutMe
            // 
            this.btmAboutMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btmAboutMe.Location = new System.Drawing.Point(187, 560);
            this.btmAboutMe.Name = "btmAboutMe";
            this.btmAboutMe.Size = new System.Drawing.Size(70, 23);
            this.btmAboutMe.TabIndex = 19;
            this.btmAboutMe.Text = "About me!";
            this.btmAboutMe.UseVisualStyleBackColor = true;
            this.btmAboutMe.Click += new System.EventHandler(this.btmAboutMe_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(133, 588);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clean for a new One";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 623);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btmAboutMe);
            this.Controls.Add(this.txtSearchInContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTool);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOpenSelectedImage);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContentName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCodeContent);
            this.Controls.Add(this.lstContents);
            this.Controls.Add(this.cboxCategories);
            this.Controls.Add(this.txtNewCatName);
            this.Controls.Add(this.btnCreateNewCat);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheCodeDB TheCodeProgram V0.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateNewCat;
        private System.Windows.Forms.TextBox txtNewCatName;
        private System.Windows.Forms.ComboBox cboxCategories;
        private System.Windows.Forms.ListBox lstContents;
        private System.Windows.Forms.RichTextBox txtCodeContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtContentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.Button btnOpenSelectedImage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTool;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchInContent;
        private System.Windows.Forms.Button btmAboutMe;
        private System.Windows.Forms.Button btnClear;
    }
}

