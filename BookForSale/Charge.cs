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
    public partial class Charge : Form
    {
        Methods fun = new Methods();
        public Charge()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txt_cartNumber.Text == "")
            {
                MessageBox.Show("Please Enter Cart Number","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (fun.typeCart(txt_cartNumber.Text) == 0)
            {
                MessageBox.Show("incorrect Cart Number", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fun.typeCart(txt_cartNumber.Text) == 1)
            {
                int coinuser = fun.getCoinUser(User.Username);
                int resultcoin = coinuser + 5000;
                fun.ChargeCoinUser(User.Username, resultcoin);
                fun.deleteCart5000(txt_cartNumber.Text);
                MessageBox.Show("Sucssice Charge 5000 Cart", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fun.typeCart(txt_cartNumber.Text) == 2)
            {
                int coinuser = fun.getCoinUser(User.Username);
                int resultcoin = coinuser + 12500;
                fun.ChargeCoinUser(User.Username, resultcoin);
                fun.deleteCart12500(txt_cartNumber.Text);
                MessageBox.Show("Sucssice Charge 12500 Cart", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_cartNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_charge.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_cartNumber.Text == "Cart Number")
            {
                txt_cartNumber.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (fun.getPower(User.Username) == 1)
            {
                Hide();
                new HomeUser().Show();
            }
            else if (fun.getPower(User.Username) == 2)
            {
                Hide();
                new HomeAdmin().Show();
            }
            else if (fun.getPower(User.Username) == 3)
            {
                Hide();
                new Home_Manager().Show();
            }
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
