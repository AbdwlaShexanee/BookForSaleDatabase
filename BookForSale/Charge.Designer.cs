namespace BookForSale
{
    partial class Charge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charge));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_cartNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_charge = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_cartNumber
            // 
            this.txt_cartNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cartNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_cartNumber.HintForeColor = System.Drawing.Color.White;
            this.txt_cartNumber.HintText = "";
            this.txt_cartNumber.isPassword = false;
            this.txt_cartNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_cartNumber.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_cartNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_cartNumber.LineThickness = 3;
            this.txt_cartNumber.Location = new System.Drawing.Point(46, 39);
            this.txt_cartNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_cartNumber.Name = "txt_cartNumber";
            this.txt_cartNumber.Size = new System.Drawing.Size(225, 41);
            this.txt_cartNumber.TabIndex = 1;
            this.txt_cartNumber.Text = "Cart Number";
            this.txt_cartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cartNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cartNumber_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 33);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_charge
            // 
            this.btn_charge.ActiveBorderThickness = 1;
            this.btn_charge.ActiveCornerRadius = 20;
            this.btn_charge.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_charge.ActiveForecolor = System.Drawing.Color.White;
            this.btn_charge.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_charge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_charge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_charge.BackgroundImage")));
            this.btn_charge.ButtonText = "Charge";
            this.btn_charge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_charge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_charge.IdleBorderThickness = 1;
            this.btn_charge.IdleCornerRadius = 20;
            this.btn_charge.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_charge.IdleForecolor = System.Drawing.Color.White;
            this.btn_charge.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_charge.Location = new System.Drawing.Point(46, 90);
            this.btn_charge.Margin = new System.Windows.Forms.Padding(5);
            this.btn_charge.Name = "btn_charge";
            this.btn_charge.Size = new System.Drawing.Size(181, 41);
            this.btn_charge.TabIndex = 1;
            this.btn_charge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_charge.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Charge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(284, 149);
            this.Controls.Add(this.btn_charge);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_cartNumber);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Charge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charge";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_cartNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_charge;
    }
}