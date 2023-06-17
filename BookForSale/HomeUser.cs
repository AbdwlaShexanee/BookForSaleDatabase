using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookForSale
{
    public partial class HomeUser : Form
    {
        Methods fun = new Methods();
        public HomeUser()
        {
            InitializeComponent();
        }

        private void HomeUser_Load(object sender, EventArgs e)
        {
            label_profilename.Text = fun.getprofileName(User.Username);
            label_usercoin.Text = fun.getCoinUser(User.Username).ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_kurdish_Click(object sender, EventArgs e)
        {
            Hide();
            new Kurdish().Show();
        }

        private void btn_english_Click(object sender, EventArgs e)
        {
            Hide();
            new English().Show();
        }

        private void btn_arabic_Click(object sender, EventArgs e)
        {
            Hide();
            new Arabic().Show();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            Hide();
            new Download().Show();
        }

        private void btn_editprofile_Click(object sender, EventArgs e)
        {
            Hide();
            new EditProfile().Show();
        }

        private void btn_Favorite_Click(object sender, EventArgs e)
        {
            Hide();
            new Favorite().Show();
        }

        private void btn_message_Click(object sender, EventArgs e)
        {
            Hide();
            new Send_Message().Show();
        }

        private void btn_buy_cart_Click(object sender, EventArgs e)
        {
            Hide();
            new BuyCart().Show();
        }

        private void btn_charge_Click(object sender, EventArgs e)
        {
            Hide();
            new Charge().Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }

        bool mouseDown;
        int mousex;
        int mousey;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mousex = e.X;
            mousey = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                SetDesktopLocation(MousePosition.X - mousex, MousePosition.Y - mousey);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}