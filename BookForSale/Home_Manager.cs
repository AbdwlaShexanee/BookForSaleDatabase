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
    public partial class Home_Manager : Form
    {
        Methods fun = new Methods();
        public Home_Manager()
        {
            InitializeComponent();
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
            new All_Message().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }

        private void btn_addbook_Click(object sender, EventArgs e)
        {
            Hide();
            new AddBook().Show();
        }

        private void btn_charge_Click(object sender, EventArgs e)
        {
            Hide();
            new Charge().Show();
        }

        private void btn_delete_book_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteBook().Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Hide();
            new Change_Power().Show();
        }

        private void btn_cart5000_Click(object sender, EventArgs e)
        {
            Hide();
            new Cart5000().Show();
        }

        private void btn_cart12500_Click(object sender, EventArgs e)
        {
            Hide();
            new Cart12500().Show();
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

        private void Home_Manager_Load(object sender, EventArgs e)
        {
            label_profilename.Text = fun.getprofileName(User.Username);
            label_coinuser.Text = fun.getCoinUser(User.Username).ToString();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }

    }
}
