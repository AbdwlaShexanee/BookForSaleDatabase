namespace BookForSale
{
    partial class Download
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Download));
            this.datashow = new System.Windows.Forms.DataGridView();
            this.Bookimage = new System.Windows.Forms.PictureBox();
            this.btn_Download = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txt_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bookimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datashow
            // 
            this.datashow.AllowUserToAddRows = false;
            this.datashow.AllowUserToDeleteRows = false;
            this.datashow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.datashow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datashow.Location = new System.Drawing.Point(12, 173);
            this.datashow.Name = "datashow";
            this.datashow.ReadOnly = true;
            this.datashow.Size = new System.Drawing.Size(886, 328);
            this.datashow.TabIndex = 0;
            this.datashow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Bookimage
            // 
            this.Bookimage.Location = new System.Drawing.Point(739, 39);
            this.Bookimage.Name = "Bookimage";
            this.Bookimage.Size = new System.Drawing.Size(159, 131);
            this.Bookimage.TabIndex = 1;
            this.Bookimage.TabStop = false;
            // 
            // btn_Download
            // 
            this.btn_Download.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Download.BorderRadius = 0;
            this.btn_Download.ButtonText = "Download Book";
            this.btn_Download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Download.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Download.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Download.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Download.Iconimage")));
            this.btn_Download.Iconimage_right = null;
            this.btn_Download.Iconimage_right_Selected = null;
            this.btn_Download.Iconimage_Selected = null;
            this.btn_Download.IconMarginLeft = 0;
            this.btn_Download.IconMarginRight = 0;
            this.btn_Download.IconRightVisible = true;
            this.btn_Download.IconRightZoom = 0D;
            this.btn_Download.IconVisible = true;
            this.btn_Download.IconZoom = 90D;
            this.btn_Download.IsTab = false;
            this.btn_Download.Location = new System.Drawing.Point(375, 116);
            this.btn_Download.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Download.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Download.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Download.selected = false;
            this.btn_Download.Size = new System.Drawing.Size(173, 50);
            this.btn_Download.TabIndex = 35;
            this.btn_Download.Text = "Download Book";
            this.btn_Download.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Download.Textcolor = System.Drawing.Color.White;
            this.btn_Download.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Download.Click += new System.EventHandler(this.btn_buybook_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, 127);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
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
            this.txt_search.Location = new System.Drawing.Point(73, 122);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(293, 44);
            this.txt_search.TabIndex = 33;
            this.txt_search.Text = "Search";
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.OnValueChanged += new System.EventHandler(this.txt_search_OnValueChanged);
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 33);
            this.panel1.TabIndex = 36;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(875, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Open Folder";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(558, 116);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(173, 50);
            this.bunifuFlatButton1.TabIndex = 37;
            this.bunifuFlatButton1.Text = "Open Folder";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(910, 513);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.Bookimage);
            this.Controls.Add(this.datashow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Download";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download";
            this.Load += new System.EventHandler(this.Download_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bookimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datashow;
        private System.Windows.Forms.PictureBox Bookimage;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Download;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}