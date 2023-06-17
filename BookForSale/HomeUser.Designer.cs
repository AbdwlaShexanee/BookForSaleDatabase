namespace BookForSale
{
    partial class HomeUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_kurdish = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_english = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_arabic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_download = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_editprofile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Favorite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_buy_cart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_message = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_charge = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_profilename = new System.Windows.Forms.Label();
            this.label_usercoin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label3.Location = new System.Drawing.Point(574, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_kurdish
            // 
            this.btn_kurdish.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_kurdish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_kurdish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kurdish.BorderRadius = 0;
            this.btn_kurdish.ButtonText = "Kurdish";
            this.btn_kurdish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kurdish.DisabledColor = System.Drawing.Color.Gray;
            this.btn_kurdish.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_kurdish.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_kurdish.Iconimage")));
            this.btn_kurdish.Iconimage_right = null;
            this.btn_kurdish.Iconimage_right_Selected = null;
            this.btn_kurdish.Iconimage_Selected = null;
            this.btn_kurdish.IconMarginLeft = 0;
            this.btn_kurdish.IconMarginRight = 0;
            this.btn_kurdish.IconRightVisible = true;
            this.btn_kurdish.IconRightZoom = 0D;
            this.btn_kurdish.IconVisible = true;
            this.btn_kurdish.IconZoom = 90D;
            this.btn_kurdish.IsTab = false;
            this.btn_kurdish.Location = new System.Drawing.Point(12, 88);
            this.btn_kurdish.Name = "btn_kurdish";
            this.btn_kurdish.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_kurdish.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_kurdish.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_kurdish.selected = false;
            this.btn_kurdish.Size = new System.Drawing.Size(143, 58);
            this.btn_kurdish.TabIndex = 1;
            this.btn_kurdish.Text = "Kurdish";
            this.btn_kurdish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kurdish.Textcolor = System.Drawing.Color.White;
            this.btn_kurdish.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kurdish.Click += new System.EventHandler(this.btn_kurdish_Click);
            // 
            // btn_english
            // 
            this.btn_english.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_english.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_english.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_english.BorderRadius = 0;
            this.btn_english.ButtonText = "English";
            this.btn_english.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_english.DisabledColor = System.Drawing.Color.Gray;
            this.btn_english.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_english.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_english.Iconimage")));
            this.btn_english.Iconimage_right = null;
            this.btn_english.Iconimage_right_Selected = null;
            this.btn_english.Iconimage_Selected = null;
            this.btn_english.IconMarginLeft = 0;
            this.btn_english.IconMarginRight = 0;
            this.btn_english.IconRightVisible = true;
            this.btn_english.IconRightZoom = 0D;
            this.btn_english.IconVisible = true;
            this.btn_english.IconZoom = 90D;
            this.btn_english.IsTab = false;
            this.btn_english.Location = new System.Drawing.Point(161, 88);
            this.btn_english.Name = "btn_english";
            this.btn_english.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_english.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_english.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_english.selected = false;
            this.btn_english.Size = new System.Drawing.Size(143, 58);
            this.btn_english.TabIndex = 2;
            this.btn_english.Text = "English";
            this.btn_english.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_english.Textcolor = System.Drawing.Color.White;
            this.btn_english.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_english.Click += new System.EventHandler(this.btn_english_Click);
            // 
            // btn_arabic
            // 
            this.btn_arabic.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_arabic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_arabic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_arabic.BorderRadius = 0;
            this.btn_arabic.ButtonText = "Arabic";
            this.btn_arabic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_arabic.DisabledColor = System.Drawing.Color.Gray;
            this.btn_arabic.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_arabic.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_arabic.Iconimage")));
            this.btn_arabic.Iconimage_right = null;
            this.btn_arabic.Iconimage_right_Selected = null;
            this.btn_arabic.Iconimage_Selected = null;
            this.btn_arabic.IconMarginLeft = 0;
            this.btn_arabic.IconMarginRight = 0;
            this.btn_arabic.IconRightVisible = true;
            this.btn_arabic.IconRightZoom = 0D;
            this.btn_arabic.IconVisible = true;
            this.btn_arabic.IconZoom = 90D;
            this.btn_arabic.IsTab = false;
            this.btn_arabic.Location = new System.Drawing.Point(310, 88);
            this.btn_arabic.Name = "btn_arabic";
            this.btn_arabic.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_arabic.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_arabic.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_arabic.selected = false;
            this.btn_arabic.Size = new System.Drawing.Size(143, 58);
            this.btn_arabic.TabIndex = 3;
            this.btn_arabic.Text = "Arabic";
            this.btn_arabic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_arabic.Textcolor = System.Drawing.Color.White;
            this.btn_arabic.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_arabic.Click += new System.EventHandler(this.btn_arabic_Click);
            // 
            // btn_download
            // 
            this.btn_download.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_download.BorderRadius = 0;
            this.btn_download.ButtonText = "Download";
            this.btn_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_download.DisabledColor = System.Drawing.Color.Gray;
            this.btn_download.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_download.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_download.Iconimage")));
            this.btn_download.Iconimage_right = null;
            this.btn_download.Iconimage_right_Selected = null;
            this.btn_download.Iconimage_Selected = null;
            this.btn_download.IconMarginLeft = 0;
            this.btn_download.IconMarginRight = 0;
            this.btn_download.IconRightVisible = true;
            this.btn_download.IconRightZoom = 0D;
            this.btn_download.IconVisible = true;
            this.btn_download.IconZoom = 90D;
            this.btn_download.IsTab = false;
            this.btn_download.Location = new System.Drawing.Point(459, 88);
            this.btn_download.Name = "btn_download";
            this.btn_download.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_download.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_download.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_download.selected = false;
            this.btn_download.Size = new System.Drawing.Size(143, 58);
            this.btn_download.TabIndex = 4;
            this.btn_download.Text = "Download";
            this.btn_download.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_download.Textcolor = System.Drawing.Color.White;
            this.btn_download.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_editprofile
            // 
            this.btn_editprofile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_editprofile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_editprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editprofile.BorderRadius = 0;
            this.btn_editprofile.ButtonText = "Edit Profile";
            this.btn_editprofile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editprofile.DisabledColor = System.Drawing.Color.Gray;
            this.btn_editprofile.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_editprofile.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_editprofile.Iconimage")));
            this.btn_editprofile.Iconimage_right = null;
            this.btn_editprofile.Iconimage_right_Selected = null;
            this.btn_editprofile.Iconimage_Selected = null;
            this.btn_editprofile.IconMarginLeft = 0;
            this.btn_editprofile.IconMarginRight = 0;
            this.btn_editprofile.IconRightVisible = true;
            this.btn_editprofile.IconRightZoom = 0D;
            this.btn_editprofile.IconVisible = true;
            this.btn_editprofile.IconZoom = 90D;
            this.btn_editprofile.IsTab = false;
            this.btn_editprofile.Location = new System.Drawing.Point(12, 152);
            this.btn_editprofile.Name = "btn_editprofile";
            this.btn_editprofile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_editprofile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_editprofile.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_editprofile.selected = false;
            this.btn_editprofile.Size = new System.Drawing.Size(143, 58);
            this.btn_editprofile.TabIndex = 5;
            this.btn_editprofile.Text = "Edit Profile";
            this.btn_editprofile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editprofile.Textcolor = System.Drawing.Color.White;
            this.btn_editprofile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editprofile.Click += new System.EventHandler(this.btn_editprofile_Click);
            // 
            // btn_Favorite
            // 
            this.btn_Favorite.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Favorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Favorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Favorite.BorderRadius = 0;
            this.btn_Favorite.ButtonText = "Favarite";
            this.btn_Favorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Favorite.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Favorite.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Favorite.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Favorite.Iconimage")));
            this.btn_Favorite.Iconimage_right = null;
            this.btn_Favorite.Iconimage_right_Selected = null;
            this.btn_Favorite.Iconimage_Selected = null;
            this.btn_Favorite.IconMarginLeft = 0;
            this.btn_Favorite.IconMarginRight = 0;
            this.btn_Favorite.IconRightVisible = true;
            this.btn_Favorite.IconRightZoom = 0D;
            this.btn_Favorite.IconVisible = true;
            this.btn_Favorite.IconZoom = 90D;
            this.btn_Favorite.IsTab = false;
            this.btn_Favorite.Location = new System.Drawing.Point(161, 152);
            this.btn_Favorite.Name = "btn_Favorite";
            this.btn_Favorite.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Favorite.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Favorite.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Favorite.selected = false;
            this.btn_Favorite.Size = new System.Drawing.Size(143, 58);
            this.btn_Favorite.TabIndex = 6;
            this.btn_Favorite.Text = "Favarite";
            this.btn_Favorite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Favorite.Textcolor = System.Drawing.Color.White;
            this.btn_Favorite.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Favorite.Click += new System.EventHandler(this.btn_Favorite_Click);
            // 
            // btn_buy_cart
            // 
            this.btn_buy_cart.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_buy_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_buy_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buy_cart.BorderRadius = 0;
            this.btn_buy_cart.ButtonText = "Buy Cart";
            this.btn_buy_cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buy_cart.DisabledColor = System.Drawing.Color.Gray;
            this.btn_buy_cart.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_buy_cart.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_buy_cart.Iconimage")));
            this.btn_buy_cart.Iconimage_right = null;
            this.btn_buy_cart.Iconimage_right_Selected = null;
            this.btn_buy_cart.Iconimage_Selected = null;
            this.btn_buy_cart.IconMarginLeft = 0;
            this.btn_buy_cart.IconMarginRight = 0;
            this.btn_buy_cart.IconRightVisible = true;
            this.btn_buy_cart.IconRightZoom = 0D;
            this.btn_buy_cart.IconVisible = true;
            this.btn_buy_cart.IconZoom = 90D;
            this.btn_buy_cart.IsTab = false;
            this.btn_buy_cart.Location = new System.Drawing.Point(459, 152);
            this.btn_buy_cart.Name = "btn_buy_cart";
            this.btn_buy_cart.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_buy_cart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_buy_cart.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_buy_cart.selected = false;
            this.btn_buy_cart.Size = new System.Drawing.Size(143, 58);
            this.btn_buy_cart.TabIndex = 8;
            this.btn_buy_cart.Text = "Buy Cart";
            this.btn_buy_cart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buy_cart.Textcolor = System.Drawing.Color.White;
            this.btn_buy_cart.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy_cart.Click += new System.EventHandler(this.btn_buy_cart_Click);
            // 
            // btn_message
            // 
            this.btn_message.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_message.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_message.BorderRadius = 0;
            this.btn_message.ButtonText = "Message";
            this.btn_message.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_message.DisabledColor = System.Drawing.Color.Gray;
            this.btn_message.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_message.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_message.Iconimage")));
            this.btn_message.Iconimage_right = null;
            this.btn_message.Iconimage_right_Selected = null;
            this.btn_message.Iconimage_Selected = null;
            this.btn_message.IconMarginLeft = 0;
            this.btn_message.IconMarginRight = 0;
            this.btn_message.IconRightVisible = true;
            this.btn_message.IconRightZoom = 0D;
            this.btn_message.IconVisible = true;
            this.btn_message.IconZoom = 90D;
            this.btn_message.IsTab = false;
            this.btn_message.Location = new System.Drawing.Point(310, 152);
            this.btn_message.Name = "btn_message";
            this.btn_message.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_message.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_message.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_message.selected = false;
            this.btn_message.Size = new System.Drawing.Size(143, 58);
            this.btn_message.TabIndex = 7;
            this.btn_message.Text = "Message";
            this.btn_message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_message.Textcolor = System.Drawing.Color.White;
            this.btn_message.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_message.Click += new System.EventHandler(this.btn_message_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logout.BorderRadius = 0;
            this.btn_logout.ButtonText = "Logout";
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.DisabledColor = System.Drawing.Color.Gray;
            this.btn_logout.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_logout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_logout.Iconimage")));
            this.btn_logout.Iconimage_right = null;
            this.btn_logout.Iconimage_right_Selected = null;
            this.btn_logout.Iconimage_Selected = null;
            this.btn_logout.IconMarginLeft = 0;
            this.btn_logout.IconMarginRight = 0;
            this.btn_logout.IconRightVisible = true;
            this.btn_logout.IconRightZoom = 0D;
            this.btn_logout.IconVisible = true;
            this.btn_logout.IconZoom = 90D;
            this.btn_logout.IsTab = false;
            this.btn_logout.Location = new System.Drawing.Point(161, 216);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_logout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_logout.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_logout.selected = false;
            this.btn_logout.Size = new System.Drawing.Size(143, 58);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Textcolor = System.Drawing.Color.White;
            this.btn_logout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_charge
            // 
            this.btn_charge.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_charge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_charge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_charge.BorderRadius = 0;
            this.btn_charge.ButtonText = "Charge";
            this.btn_charge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_charge.DisabledColor = System.Drawing.Color.Gray;
            this.btn_charge.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_charge.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_charge.Iconimage")));
            this.btn_charge.Iconimage_right = null;
            this.btn_charge.Iconimage_right_Selected = null;
            this.btn_charge.Iconimage_Selected = null;
            this.btn_charge.IconMarginLeft = 0;
            this.btn_charge.IconMarginRight = 0;
            this.btn_charge.IconRightVisible = true;
            this.btn_charge.IconRightZoom = 0D;
            this.btn_charge.IconVisible = true;
            this.btn_charge.IconZoom = 90D;
            this.btn_charge.IsTab = false;
            this.btn_charge.Location = new System.Drawing.Point(12, 216);
            this.btn_charge.Name = "btn_charge";
            this.btn_charge.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_charge.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_charge.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_charge.selected = false;
            this.btn_charge.Size = new System.Drawing.Size(143, 58);
            this.btn_charge.TabIndex = 9;
            this.btn_charge.Text = "Charge";
            this.btn_charge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_charge.Textcolor = System.Drawing.Color.White;
            this.btn_charge.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_charge.Click += new System.EventHandler(this.btn_charge_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(267, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label_profilename
            // 
            this.label_profilename.AutoSize = true;
            this.label_profilename.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label_profilename.Location = new System.Drawing.Point(62, 44);
            this.label_profilename.Name = "label_profilename";
            this.label_profilename.Size = new System.Drawing.Size(18, 16);
            this.label_profilename.TabIndex = 13;
            this.label_profilename.Text = "A";
            // 
            // label_usercoin
            // 
            this.label_usercoin.AutoSize = true;
            this.label_usercoin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usercoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label_usercoin.Location = new System.Drawing.Point(325, 44);
            this.label_usercoin.Name = "label_usercoin";
            this.label_usercoin.Size = new System.Drawing.Size(16, 16);
            this.label_usercoin.TabIndex = 14;
            this.label_usercoin.Text = "0";
            // 
            // HomeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(606, 289);
            this.Controls.Add(this.label_usercoin);
            this.Controls.Add(this.label_profilename);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_charge);
            this.Controls.Add(this.btn_buy_cart);
            this.Controls.Add(this.btn_message);
            this.Controls.Add(this.btn_Favorite);
            this.Controls.Add(this.btn_editprofile);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.btn_arabic);
            this.Controls.Add(this.btn_english);
            this.Controls.Add(this.btn_kurdish);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeUser";
            this.Load += new System.EventHandler(this.HomeUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_kurdish;
        private Bunifu.Framework.UI.BunifuFlatButton btn_english;
        private Bunifu.Framework.UI.BunifuFlatButton btn_arabic;
        private Bunifu.Framework.UI.BunifuFlatButton btn_download;
        private Bunifu.Framework.UI.BunifuFlatButton btn_editprofile;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Favorite;
        private Bunifu.Framework.UI.BunifuFlatButton btn_buy_cart;
        private Bunifu.Framework.UI.BunifuFlatButton btn_message;
        private Bunifu.Framework.UI.BunifuFlatButton btn_logout;
        private Bunifu.Framework.UI.BunifuFlatButton btn_charge;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_profilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_usercoin;
    }
}