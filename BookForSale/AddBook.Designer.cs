namespace BookForSale
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_title = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.imageBook = new System.Windows.Forms.PictureBox();
            this.txt_namecreated = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_years_created = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_catagories = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_pageNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Cost = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_URL = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Btn_Browse = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_addBook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_language = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 32);
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
            this.label1.Location = new System.Drawing.Point(411, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_title
            // 
            this.txt_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_title.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_title.HintText = "";
            this.txt_title.isPassword = false;
            this.txt_title.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_title.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_title.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_title.LineThickness = 3;
            this.txt_title.Location = new System.Drawing.Point(159, 49);
            this.txt_title.Margin = new System.Windows.Forms.Padding(4);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(272, 33);
            this.txt_title.TabIndex = 1;
            this.txt_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_title.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_title_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label3.Location = new System.Drawing.Point(5, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name Created";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label4.Location = new System.Drawing.Point(11, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Years Created";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label5.Location = new System.Drawing.Point(13, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Language";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Catagories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label7.Location = new System.Drawing.Point(12, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Page Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label8.Location = new System.Drawing.Point(13, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label9.Location = new System.Drawing.Point(13, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "URL Book";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label10.Location = new System.Drawing.Point(13, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Photo Book";
            // 
            // imageBook
            // 
            this.imageBook.Location = new System.Drawing.Point(142, 369);
            this.imageBook.Name = "imageBook";
            this.imageBook.Size = new System.Drawing.Size(145, 91);
            this.imageBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBook.TabIndex = 12;
            this.imageBook.TabStop = false;
            // 
            // txt_namecreated
            // 
            this.txt_namecreated.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_namecreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_namecreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_namecreated.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_namecreated.HintText = "";
            this.txt_namecreated.isPassword = false;
            this.txt_namecreated.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_namecreated.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_namecreated.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_namecreated.LineThickness = 3;
            this.txt_namecreated.Location = new System.Drawing.Point(159, 90);
            this.txt_namecreated.Margin = new System.Windows.Forms.Padding(4);
            this.txt_namecreated.Name = "txt_namecreated";
            this.txt_namecreated.Size = new System.Drawing.Size(272, 33);
            this.txt_namecreated.TabIndex = 13;
            this.txt_namecreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_namecreated.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_namecreated_KeyDown);
            // 
            // txt_years_created
            // 
            this.txt_years_created.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_years_created.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_years_created.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_years_created.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_years_created.HintText = "";
            this.txt_years_created.isPassword = false;
            this.txt_years_created.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_years_created.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_years_created.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_years_created.LineThickness = 3;
            this.txt_years_created.Location = new System.Drawing.Point(159, 131);
            this.txt_years_created.Margin = new System.Windows.Forms.Padding(4);
            this.txt_years_created.Name = "txt_years_created";
            this.txt_years_created.Size = new System.Drawing.Size(272, 33);
            this.txt_years_created.TabIndex = 14;
            this.txt_years_created.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_catagories
            // 
            this.txt_catagories.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_catagories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_catagories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_catagories.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_catagories.HintText = "";
            this.txt_catagories.isPassword = false;
            this.txt_catagories.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_catagories.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_catagories.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_catagories.LineThickness = 3;
            this.txt_catagories.Location = new System.Drawing.Point(159, 204);
            this.txt_catagories.Margin = new System.Windows.Forms.Padding(4);
            this.txt_catagories.Name = "txt_catagories";
            this.txt_catagories.Size = new System.Drawing.Size(272, 33);
            this.txt_catagories.TabIndex = 16;
            this.txt_catagories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_catagories.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_catagories_KeyDown);
            // 
            // txt_pageNumber
            // 
            this.txt_pageNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_pageNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_pageNumber.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_pageNumber.HintText = "";
            this.txt_pageNumber.isPassword = false;
            this.txt_pageNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_pageNumber.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_pageNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_pageNumber.LineThickness = 3;
            this.txt_pageNumber.Location = new System.Drawing.Point(159, 245);
            this.txt_pageNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pageNumber.Name = "txt_pageNumber";
            this.txt_pageNumber.Size = new System.Drawing.Size(272, 33);
            this.txt_pageNumber.TabIndex = 17;
            this.txt_pageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pageNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pageNumber_KeyDown);
            // 
            // txt_Cost
            // 
            this.txt_Cost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_Cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_Cost.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_Cost.HintText = "";
            this.txt_Cost.isPassword = false;
            this.txt_Cost.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_Cost.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_Cost.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_Cost.LineThickness = 3;
            this.txt_Cost.Location = new System.Drawing.Point(159, 286);
            this.txt_Cost.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cost.Name = "txt_Cost";
            this.txt_Cost.Size = new System.Drawing.Size(272, 33);
            this.txt_Cost.TabIndex = 18;
            this.txt_Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Cost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Cost_KeyDown);
            // 
            // txt_URL
            // 
            this.txt_URL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_URL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_URL.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_URL.HintText = "";
            this.txt_URL.isPassword = false;
            this.txt_URL.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_URL.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_URL.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txt_URL.LineThickness = 3;
            this.txt_URL.Location = new System.Drawing.Point(159, 327);
            this.txt_URL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(272, 33);
            this.txt_URL.TabIndex = 19;
            this.txt_URL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_URL_KeyDown);
            // 
            // Btn_Browse
            // 
            this.Btn_Browse.ActiveBorderThickness = 1;
            this.Btn_Browse.ActiveCornerRadius = 20;
            this.Btn_Browse.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.Btn_Browse.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Browse.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.Btn_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Btn_Browse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Browse.BackgroundImage")));
            this.Btn_Browse.ButtonText = "Browse";
            this.Btn_Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Browse.ForeColor = System.Drawing.Color.White;
            this.Btn_Browse.IdleBorderThickness = 1;
            this.Btn_Browse.IdleCornerRadius = 20;
            this.Btn_Browse.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.Btn_Browse.IdleForecolor = System.Drawing.Color.White;
            this.Btn_Browse.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.Btn_Browse.Location = new System.Drawing.Point(297, 379);
            this.Btn_Browse.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_Browse.Name = "Btn_Browse";
            this.Btn_Browse.Size = new System.Drawing.Size(134, 49);
            this.Btn_Browse.TabIndex = 20;
            this.Btn_Browse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Browse.Click += new System.EventHandler(this.Btn_Browse_Click);
            // 
            // btn_addBook
            // 
            this.btn_addBook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_addBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_addBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addBook.BorderRadius = 0;
            this.btn_addBook.ButtonText = "Add Book";
            this.btn_addBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addBook.DisabledColor = System.Drawing.Color.Gray;
            this.btn_addBook.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_addBook.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_addBook.Iconimage")));
            this.btn_addBook.Iconimage_right = null;
            this.btn_addBook.Iconimage_right_Selected = null;
            this.btn_addBook.Iconimage_Selected = null;
            this.btn_addBook.IconMarginLeft = 0;
            this.btn_addBook.IconMarginRight = 0;
            this.btn_addBook.IconRightVisible = true;
            this.btn_addBook.IconRightZoom = 0D;
            this.btn_addBook.IconVisible = true;
            this.btn_addBook.IconZoom = 90D;
            this.btn_addBook.IsTab = false;
            this.btn_addBook.Location = new System.Drawing.Point(190, 489);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_addBook.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_addBook.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_addBook.selected = false;
            this.btn_addBook.Size = new System.Drawing.Size(164, 48);
            this.btn_addBook.TabIndex = 21;
            this.btn_addBook.Text = "Add Book";
            this.btn_addBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addBook.Textcolor = System.Drawing.Color.White;
            this.btn_addBook.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Home.BorderRadius = 0;
            this.btn_Home.ButtonText = "Home";
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Home.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Home.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Home.Iconimage")));
            this.btn_Home.Iconimage_right = null;
            this.btn_Home.Iconimage_right_Selected = null;
            this.btn_Home.Iconimage_Selected = null;
            this.btn_Home.IconMarginLeft = 0;
            this.btn_Home.IconMarginRight = 0;
            this.btn_Home.IconRightVisible = true;
            this.btn_Home.IconRightZoom = 0D;
            this.btn_Home.IconVisible = true;
            this.btn_Home.IconZoom = 90D;
            this.btn_Home.IsTab = false;
            this.btn_Home.Location = new System.Drawing.Point(20, 489);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Home.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Home.selected = false;
            this.btn_Home.Size = new System.Drawing.Size(164, 48);
            this.btn_Home.TabIndex = 22;
            this.btn_Home.Text = "Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Textcolor = System.Drawing.Color.White;
            this.btn_Home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // txt_language
            // 
            this.txt_language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_language.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_language.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_language.FormattingEnabled = true;
            this.txt_language.Items.AddRange(new object[] {
            "Kurdish",
            "English",
            "Arabic"});
            this.txt_language.Location = new System.Drawing.Point(159, 176);
            this.txt_language.Name = "txt_language";
            this.txt_language.Size = new System.Drawing.Size(271, 31);
            this.txt_language.TabIndex = 23;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(442, 558);
            this.Controls.Add(this.txt_language);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_addBook);
            this.Controls.Add(this.Btn_Browse);
            this.Controls.Add(this.txt_URL);
            this.Controls.Add(this.txt_Cost);
            this.Controls.Add(this.txt_pageNumber);
            this.Controls.Add(this.txt_catagories);
            this.Controls.Add(this.txt_years_created);
            this.Controls.Add(this.txt_namecreated);
            this.Controls.Add(this.imageBook);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox imageBook;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_namecreated;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_years_created;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_catagories;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_pageNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Cost;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_URL;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Browse;
        private Bunifu.Framework.UI.BunifuFlatButton btn_addBook;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Home;
        private System.Windows.Forms.ComboBox txt_language;
    }
}