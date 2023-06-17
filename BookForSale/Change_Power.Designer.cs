namespace BookForSale
{
    partial class Change_Power
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Power));
            this.txt_select_power = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_changePower = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_select_power
            // 
            this.txt_select_power.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_select_power.FormattingEnabled = true;
            this.txt_select_power.Items.AddRange(new object[] {
            "BlockUser",
            "NormalUser",
            "AdminUser",
            "ManagerUser"});
            this.txt_select_power.Location = new System.Drawing.Point(12, 32);
            this.txt_select_power.Name = "txt_select_power";
            this.txt_select_power.Size = new System.Drawing.Size(211, 27);
            this.txt_select_power.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 26);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(203, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_username
            // 
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_username.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_username.HintText = "";
            this.txt_username.isPassword = false;
            this.txt_username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_username.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_username.LineThickness = 3;
            this.txt_username.Location = new System.Drawing.Point(14, 76);
            this.txt_username.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(209, 37);
            this.txt_username.TabIndex = 2;
            this.txt_username.Text = "UserName";
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_username_KeyDown);
            // 
            // btn_changePower
            // 
            this.btn_changePower.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_changePower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_changePower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_changePower.BorderRadius = 0;
            this.btn_changePower.ButtonText = "Change Power";
            this.btn_changePower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_changePower.DisabledColor = System.Drawing.Color.Gray;
            this.btn_changePower.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_changePower.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_changePower.Iconimage")));
            this.btn_changePower.Iconimage_right = null;
            this.btn_changePower.Iconimage_right_Selected = null;
            this.btn_changePower.Iconimage_Selected = null;
            this.btn_changePower.IconMarginLeft = 0;
            this.btn_changePower.IconMarginRight = 0;
            this.btn_changePower.IconRightVisible = true;
            this.btn_changePower.IconRightZoom = 0D;
            this.btn_changePower.IconVisible = true;
            this.btn_changePower.IconZoom = 90D;
            this.btn_changePower.IsTab = false;
            this.btn_changePower.Location = new System.Drawing.Point(12, 135);
            this.btn_changePower.Name = "btn_changePower";
            this.btn_changePower.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_changePower.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_changePower.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_changePower.selected = false;
            this.btn_changePower.Size = new System.Drawing.Size(211, 48);
            this.btn_changePower.TabIndex = 3;
            this.btn_changePower.Text = "Change Power";
            this.btn_changePower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_changePower.Textcolor = System.Drawing.Color.White;
            this.btn_changePower.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePower.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Change_Power
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(231, 199);
            this.Controls.Add(this.btn_changePower);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_select_power);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Change_Power";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_Power";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_select_power;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_username;
        private Bunifu.Framework.UI.BunifuFlatButton btn_changePower;
    }
}