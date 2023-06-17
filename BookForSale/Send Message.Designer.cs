namespace BookForSale
{
    partial class Send_Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Send_Message));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_title = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.btn_send = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 28);
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
            this.label1.Location = new System.Drawing.Point(491, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_title
            // 
            this.txt_title.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_title.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_title.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_title.BorderThickness = 3;
            this.txt_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_title.isPassword = false;
            this.txt_title.Location = new System.Drawing.Point(12, 50);
            this.txt_title.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(499, 50);
            this.txt_title.TabIndex = 1;
            this.txt_title.Text = "Title";
            this.txt_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_message
            // 
            this.txt_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_message.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_message.Location = new System.Drawing.Point(12, 121);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(499, 293);
            this.txt_message.TabIndex = 2;
            this.txt_message.Text = "Message";
            // 
            // btn_send
            // 
            this.btn_send.ActiveBorderThickness = 1;
            this.btn_send.ActiveCornerRadius = 20;
            this.btn_send.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_send.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_send.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_send.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_send.BackgroundImage")));
            this.btn_send.ButtonText = "Send";
            this.btn_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_send.IdleBorderThickness = 1;
            this.btn_send.IdleCornerRadius = 20;
            this.btn_send.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_send.IdleForecolor = System.Drawing.Color.White;
            this.btn_send.IdleLineColor = System.Drawing.Color.White;
            this.btn_send.Location = new System.Drawing.Point(139, 423);
            this.btn_send.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(226, 49);
            this.btn_send.TabIndex = 5;
            this.btn_send.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Send_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(523, 480);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Send_Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send_Message";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_title;
        private System.Windows.Forms.TextBox txt_message;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_send;
    }
}