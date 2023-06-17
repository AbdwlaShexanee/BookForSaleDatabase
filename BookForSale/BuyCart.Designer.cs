namespace BookForSale
{
    partial class BuyCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyCart));
            this.txt_cartNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_selectCart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_send = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cartNumber
            // 
            this.txt_cartNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cartNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_cartNumber.HintForeColor = System.Drawing.Color.Empty;
            this.txt_cartNumber.HintText = "";
            this.txt_cartNumber.isPassword = false;
            this.txt_cartNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_cartNumber.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_cartNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_cartNumber.LineThickness = 3;
            this.txt_cartNumber.Location = new System.Drawing.Point(67, 130);
            this.txt_cartNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_cartNumber.Name = "txt_cartNumber";
            this.txt_cartNumber.Size = new System.Drawing.Size(250, 37);
            this.txt_cartNumber.TabIndex = 0;
            this.txt_cartNumber.Text = "Cart Number";
            this.txt_cartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cartNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cartNumber_KeyDown);
            // 
            // txt_selectCart
            // 
            this.txt_selectCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_selectCart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_selectCart.ForeColor = System.Drawing.Color.White;
            this.txt_selectCart.FormattingEnabled = true;
            this.txt_selectCart.Items.AddRange(new object[] {
            "5000",
            "12500"});
            this.txt_selectCart.Location = new System.Drawing.Point(96, 96);
            this.txt_selectCart.Name = "txt_selectCart";
            this.txt_selectCart.Size = new System.Drawing.Size(184, 27);
            this.txt_selectCart.TabIndex = 1;
            this.txt_selectCart.Text = "Type Cart";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "if you select Cart 5000 type number cart 5000 but select cart 12500 type number c" +
    "art 10000";
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
            this.btn_send.Location = new System.Drawing.Point(112, 174);
            this.btn_send.Name = "btn_send";
            this.btn_send.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_send.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_send.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_send.selected = false;
            this.btn_send.Size = new System.Drawing.Size(124, 48);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Send";
            this.btn_send.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_send.Textcolor = System.Drawing.Color.White;
            this.btn_send.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 31);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.exit.Location = new System.Drawing.Point(296, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 19);
            this.exit.TabIndex = 4;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // BuyCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(323, 231);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_selectCart);
            this.Controls.Add(this.txt_cartNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyCart";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_cartNumber;
        private System.Windows.Forms.ComboBox txt_selectCart;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_send;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}