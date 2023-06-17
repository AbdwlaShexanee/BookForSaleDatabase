namespace BookForSale
{
    partial class Cart12500
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart12500));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CartNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_send = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_refreash = new Bunifu.Framework.UI.BunifuFlatButton();
            this.datashow = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 28);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_CartNumber
            // 
            this.txt_CartNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_CartNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_CartNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_CartNumber.BorderThickness = 3;
            this.txt_CartNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_CartNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_CartNumber.isPassword = false;
            this.txt_CartNumber.Location = new System.Drawing.Point(69, 94);
            this.txt_CartNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CartNumber.Name = "txt_CartNumber";
            this.txt_CartNumber.Size = new System.Drawing.Size(261, 40);
            this.txt_CartNumber.TabIndex = 18;
            this.txt_CartNumber.Text = "Cart Number";
            this.txt_CartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CartNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CartNumber_KeyDown);
            // 
            // txt_username
            // 
            this.txt_username.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_username.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_username.BorderThickness = 3;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_username.isPassword = false;
            this.txt_username.Location = new System.Drawing.Point(70, 46);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(261, 42);
            this.txt_username.TabIndex = 17;
            this.txt_username.Text = "Username";
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuMetroTextbox1_KeyDown);
            // 
            // btn_send
            // 
            this.btn_send.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_send.BorderRadius = 0;
            this.btn_send.ButtonText = "Send";
            this.btn_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send.DisabledColor = System.Drawing.Color.Gray;
            this.btn_send.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_send.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_send.Iconimage")));
            this.btn_send.Iconimage_right = null;
            this.btn_send.Iconimage_right_Selected = null;
            this.btn_send.Iconimage_Selected = null;
            this.btn_send.IconMarginLeft = 0;
            this.btn_send.IconMarginRight = 0;
            this.btn_send.IconRightVisible = true;
            this.btn_send.IconRightZoom = 0D;
            this.btn_send.IconVisible = true;
            this.btn_send.IconZoom = 90D;
            this.btn_send.IsTab = false;
            this.btn_send.Location = new System.Drawing.Point(176, 141);
            this.btn_send.Name = "btn_send";
            this.btn_send.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_send.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_send.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_send.selected = false;
            this.btn_send.Size = new System.Drawing.Size(154, 48);
            this.btn_send.TabIndex = 16;
            this.btn_send.Text = "Send";
            this.btn_send.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_send.Textcolor = System.Drawing.Color.White;
            this.btn_send.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_refreash
            // 
            this.btn_refreash.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_refreash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_refreash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refreash.BorderRadius = 0;
            this.btn_refreash.ButtonText = "Refresh";
            this.btn_refreash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refreash.DisabledColor = System.Drawing.Color.Gray;
            this.btn_refreash.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_refreash.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_refreash.Iconimage")));
            this.btn_refreash.Iconimage_right = null;
            this.btn_refreash.Iconimage_right_Selected = null;
            this.btn_refreash.Iconimage_Selected = null;
            this.btn_refreash.IconMarginLeft = 0;
            this.btn_refreash.IconMarginRight = 0;
            this.btn_refreash.IconRightVisible = true;
            this.btn_refreash.IconRightZoom = 0D;
            this.btn_refreash.IconVisible = true;
            this.btn_refreash.IconZoom = 90D;
            this.btn_refreash.IsTab = false;
            this.btn_refreash.Location = new System.Drawing.Point(12, 142);
            this.btn_refreash.Name = "btn_refreash";
            this.btn_refreash.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_refreash.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_refreash.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_refreash.selected = false;
            this.btn_refreash.Size = new System.Drawing.Size(147, 48);
            this.btn_refreash.TabIndex = 15;
            this.btn_refreash.Text = "Refresh";
            this.btn_refreash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refreash.Textcolor = System.Drawing.Color.White;
            this.btn_refreash.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refreash.Click += new System.EventHandler(this.btn_refreash_Click);
            // 
            // datashow
            // 
            this.datashow.AllowUserToAddRows = false;
            this.datashow.AllowUserToDeleteRows = false;
            this.datashow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.datashow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datashow.Location = new System.Drawing.Point(12, 195);
            this.datashow.Name = "datashow";
            this.datashow.ReadOnly = true;
            this.datashow.Size = new System.Drawing.Size(319, 226);
            this.datashow.TabIndex = 14;
            this.datashow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datashow_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Cart12500
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(336, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_CartNumber);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_refreash);
            this.Controls.Add(this.datashow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cart12500";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart12500";
            this.Load += new System.EventHandler(this.Cart12500_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_CartNumber;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_username;
        private Bunifu.Framework.UI.BunifuFlatButton btn_send;
        private Bunifu.Framework.UI.BunifuFlatButton btn_refreash;
        private System.Windows.Forms.DataGridView datashow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}