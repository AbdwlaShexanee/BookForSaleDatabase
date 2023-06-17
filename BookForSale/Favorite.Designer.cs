namespace BookForSale
{
    partial class Favorite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favorite));
            this.datashow = new System.Windows.Forms.DataGridView();
            this.Bookimage = new System.Windows.Forms.PictureBox();
            this.txt_nrxekteb = new System.Windows.Forms.Label();
            this.label_usercoin = new System.Windows.Forms.Label();
            this.label_profilename = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txt_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buybook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_addtofavarite = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bookimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datashow
            // 
            this.datashow.AllowUserToAddRows = false;
            this.datashow.AllowUserToDeleteRows = false;
            this.datashow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.datashow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datashow.Location = new System.Drawing.Point(13, 180);
            this.datashow.Name = "datashow";
            this.datashow.ReadOnly = true;
            this.datashow.Size = new System.Drawing.Size(882, 433);
            this.datashow.TabIndex = 0;
            this.datashow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Bookimage
            // 
            this.Bookimage.Location = new System.Drawing.Point(720, 33);
            this.Bookimage.Name = "Bookimage";
            this.Bookimage.Size = new System.Drawing.Size(123, 103);
            this.Bookimage.TabIndex = 1;
            this.Bookimage.TabStop = false;
            // 
            // txt_nrxekteb
            // 
            this.txt_nrxekteb.AutoSize = true;
            this.txt_nrxekteb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nrxekteb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_nrxekteb.Location = new System.Drawing.Point(429, 44);
            this.txt_nrxekteb.Name = "txt_nrxekteb";
            this.txt_nrxekteb.Size = new System.Drawing.Size(16, 16);
            this.txt_nrxekteb.TabIndex = 29;
            this.txt_nrxekteb.Text = "0";
            // 
            // label_usercoin
            // 
            this.label_usercoin.AutoSize = true;
            this.label_usercoin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usercoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label_usercoin.Location = new System.Drawing.Point(70, 92);
            this.label_usercoin.Name = "label_usercoin";
            this.label_usercoin.Size = new System.Drawing.Size(16, 16);
            this.label_usercoin.TabIndex = 28;
            this.label_usercoin.Text = "0";
            // 
            // label_profilename
            // 
            this.label_profilename.AutoSize = true;
            this.label_profilename.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label_profilename.Location = new System.Drawing.Point(70, 44);
            this.label_profilename.Name = "label_profilename";
            this.label_profilename.Size = new System.Drawing.Size(18, 16);
            this.label_profilename.TabIndex = 27;
            this.label_profilename.Text = "A";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, 130);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_search.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_search.BorderThickness = 3;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_search.isPassword = false;
            this.txt_search.Location = new System.Drawing.Point(73, 125);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(306, 44);
            this.txt_search.TabIndex = 25;
            this.txt_search.Text = "Search";
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.OnValueChanged += new System.EventHandler(this.txt_search_OnValueChanged);
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(374, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 27);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(875, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_buybook
            // 
            this.btn_buybook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_buybook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_buybook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buybook.BorderRadius = 0;
            this.btn_buybook.ButtonText = "Buy Book";
            this.btn_buybook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buybook.DisabledColor = System.Drawing.Color.Gray;
            this.btn_buybook.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_buybook.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_buybook.Iconimage")));
            this.btn_buybook.Iconimage_right = null;
            this.btn_buybook.Iconimage_right_Selected = null;
            this.btn_buybook.Iconimage_Selected = null;
            this.btn_buybook.IconMarginLeft = 0;
            this.btn_buybook.IconMarginRight = 0;
            this.btn_buybook.IconRightVisible = true;
            this.btn_buybook.IconRightZoom = 0D;
            this.btn_buybook.IconVisible = true;
            this.btn_buybook.IconZoom = 90D;
            this.btn_buybook.IsTab = false;
            this.btn_buybook.Location = new System.Drawing.Point(398, 119);
            this.btn_buybook.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_buybook.Name = "btn_buybook";
            this.btn_buybook.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_buybook.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_buybook.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_buybook.selected = false;
            this.btn_buybook.Size = new System.Drawing.Size(152, 50);
            this.btn_buybook.TabIndex = 32;
            this.btn_buybook.Text = "Buy Book";
            this.btn_buybook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buybook.Textcolor = System.Drawing.Color.White;
            this.btn_buybook.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buybook.Click += new System.EventHandler(this.btn_buybook_Click);
            // 
            // btn_addtofavarite
            // 
            this.btn_addtofavarite.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_addtofavarite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_addtofavarite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addtofavarite.BorderRadius = 0;
            this.btn_addtofavarite.ButtonText = "Un Favarite";
            this.btn_addtofavarite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addtofavarite.DisabledColor = System.Drawing.Color.Gray;
            this.btn_addtofavarite.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_addtofavarite.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_addtofavarite.Iconimage")));
            this.btn_addtofavarite.Iconimage_right = null;
            this.btn_addtofavarite.Iconimage_right_Selected = null;
            this.btn_addtofavarite.Iconimage_Selected = null;
            this.btn_addtofavarite.IconMarginLeft = 0;
            this.btn_addtofavarite.IconMarginRight = 0;
            this.btn_addtofavarite.IconRightVisible = true;
            this.btn_addtofavarite.IconRightZoom = 0D;
            this.btn_addtofavarite.IconVisible = true;
            this.btn_addtofavarite.IconZoom = 90D;
            this.btn_addtofavarite.IsTab = false;
            this.btn_addtofavarite.Location = new System.Drawing.Point(560, 119);
            this.btn_addtofavarite.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_addtofavarite.Name = "btn_addtofavarite";
            this.btn_addtofavarite.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_addtofavarite.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_addtofavarite.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_addtofavarite.selected = false;
            this.btn_addtofavarite.Size = new System.Drawing.Size(152, 50);
            this.btn_addtofavarite.TabIndex = 31;
            this.btn_addtofavarite.Text = "Un Favarite";
            this.btn_addtofavarite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addtofavarite.Textcolor = System.Drawing.Color.White;
            this.btn_addtofavarite.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addtofavarite.Click += new System.EventHandler(this.btn_addtofavarite_Click);
            // 
            // Favorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(906, 616);
            this.Controls.Add(this.btn_buybook);
            this.Controls.Add(this.btn_addtofavarite);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_nrxekteb);
            this.Controls.Add(this.label_usercoin);
            this.Controls.Add(this.label_profilename);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Bookimage);
            this.Controls.Add(this.datashow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Favorite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Favorite";
            this.Load += new System.EventHandler(this.Favorite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bookimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datashow;
        private System.Windows.Forms.PictureBox Bookimage;
        private System.Windows.Forms.Label txt_nrxekteb;
        private System.Windows.Forms.Label label_usercoin;
        private System.Windows.Forms.Label label_profilename;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_search;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_buybook;
        private Bunifu.Framework.UI.BunifuFlatButton btn_addtofavarite;
        private System.Windows.Forms.Label label1;
    }
}