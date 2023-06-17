namespace BookForSale
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ProfileName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PasswordProfile = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Profile = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_pass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_repass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_OldPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 27);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(398, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_ProfileName
            // 
            this.txt_ProfileName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_ProfileName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_ProfileName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_ProfileName.BorderThickness = 3;
            this.txt_ProfileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProfileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_ProfileName.isPassword = false;
            this.txt_ProfileName.Location = new System.Drawing.Point(128, 78);
            this.txt_ProfileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ProfileName.Name = "txt_ProfileName";
            this.txt_ProfileName.Size = new System.Drawing.Size(292, 28);
            this.txt_ProfileName.TabIndex = 1;
            this.txt_ProfileName.Text = "Profile Name";
            this.txt_ProfileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ProfileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuMetroTextbox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profile Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label3.Location = new System.Drawing.Point(130, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Change Profile Name";
            // 
            // txt_PasswordProfile
            // 
            this.txt_PasswordProfile.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_PasswordProfile.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_PasswordProfile.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_PasswordProfile.BorderThickness = 3;
            this.txt_PasswordProfile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PasswordProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PasswordProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_PasswordProfile.isPassword = false;
            this.txt_PasswordProfile.Location = new System.Drawing.Point(128, 116);
            this.txt_PasswordProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PasswordProfile.Name = "txt_PasswordProfile";
            this.txt_PasswordProfile.Size = new System.Drawing.Size(292, 28);
            this.txt_PasswordProfile.TabIndex = 4;
            this.txt_PasswordProfile.Text = "Password";
            this.txt_PasswordProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PasswordProfile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuMetroTextbox2_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // btn_Profile
            // 
            this.btn_Profile.ActiveBorderThickness = 1;
            this.btn_Profile.ActiveCornerRadius = 20;
            this.btn_Profile.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Profile.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Profile.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Profile.BackgroundImage")));
            this.btn_Profile.ButtonText = "Change Profile Name";
            this.btn_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Profile.IdleBorderThickness = 1;
            this.btn_Profile.IdleCornerRadius = 20;
            this.btn_Profile.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Profile.IdleForecolor = System.Drawing.Color.White;
            this.btn_Profile.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Profile.Location = new System.Drawing.Point(125, 164);
            this.btn_Profile.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(201, 41);
            this.btn_Profile.TabIndex = 6;
            this.btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_pass
            // 
            this.btn_pass.ActiveBorderThickness = 1;
            this.btn_pass.ActiveCornerRadius = 20;
            this.btn_pass.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_pass.ActiveForecolor = System.Drawing.Color.White;
            this.btn_pass.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pass.BackgroundImage")));
            this.btn_pass.ButtonText = "Change Password";
            this.btn_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_pass.IdleBorderThickness = 1;
            this.btn_pass.IdleCornerRadius = 20;
            this.btn_pass.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_pass.IdleForecolor = System.Drawing.Color.White;
            this.btn_pass.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_pass.Location = new System.Drawing.Point(125, 343);
            this.btn_pass.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(201, 41);
            this.btn_pass.TabIndex = 11;
            this.btn_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pass.Click += new System.EventHandler(this.btn_pass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label5.Location = new System.Drawing.Point(12, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "RePassword";
            // 
            // txt_repass
            // 
            this.txt_repass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_repass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_repass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_repass.BorderThickness = 3;
            this.txt_repass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_repass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_repass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_repass.isPassword = false;
            this.txt_repass.Location = new System.Drawing.Point(130, 295);
            this.txt_repass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_repass.Name = "txt_repass";
            this.txt_repass.Size = new System.Drawing.Size(292, 28);
            this.txt_repass.TabIndex = 9;
            this.txt_repass.Text = "RePassword";
            this.txt_repass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_repass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuMetroTextbox3_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label6.Location = new System.Drawing.Point(12, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // txt_pass
            // 
            this.txt_pass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_pass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_pass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_pass.BorderThickness = 3;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_pass.isPassword = false;
            this.txt_pass.Location = new System.Drawing.Point(130, 257);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(292, 28);
            this.txt_pass.TabIndex = 7;
            this.txt_pass.Text = "Password";
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuMetroTextbox4_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label7.Location = new System.Drawing.Point(8, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Old Password";
            // 
            // txt_OldPass
            // 
            this.txt_OldPass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_OldPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_OldPass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_OldPass.BorderThickness = 3;
            this.txt_OldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OldPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_OldPass.isPassword = false;
            this.txt_OldPass.Location = new System.Drawing.Point(130, 223);
            this.txt_OldPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OldPass.Name = "txt_OldPass";
            this.txt_OldPass.Size = new System.Drawing.Size(292, 28);
            this.txt_OldPass.TabIndex = 12;
            this.txt_OldPass.Text = "Old Password";
            this.txt_OldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_OldPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuMetroTextbox5_KeyDown);
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(430, 440);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_OldPass);
            this.Controls.Add(this.btn_pass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_repass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.btn_Profile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_PasswordProfile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ProfileName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ProfileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_PasswordProfile;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Profile;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_pass;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_repass;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_pass;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_OldPass;
    }
}