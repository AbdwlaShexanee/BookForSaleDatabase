using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookForSale
{
    public partial class BuyCart : Form
    {
        Methods fun = new Methods();
        public BuyCart()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (txt_selectCart.Text == "Type Cart" || txt_cartNumber.Text == "" || txt_cartNumber.Text == "Cart Number")
            {
                MessageBox.Show("Please Complite All Fild ", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          else
            {
                try
                {
                    WebClient client = new WebClient();
                    Stream s = client.OpenRead("https://platform.clickatell.com/messages/http/send?apiKey=bRjT-F1IS1momf_fsibAuQ==&to=9647507534635&content=" + "Book For Sale" + Environment.NewLine + "Hellow Mr " + User.Username + Environment.NewLine + "Type Cart "+txt_selectCart.Text + Environment.NewLine + "Cart Number : " + txt_cartNumber.Text + Environment.NewLine + "Best Regard");
                    StreamReader reader = new StreamReader(s);
                    MessageBox.Show("Sucssice Send Cart", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_cartNumber.Text = "";
                    txt_selectCart.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_cartNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
            else if (txt_cartNumber.Text == "Cart Number")
            {
                txt_cartNumber.Text = "";
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

        private void exit_Click(object sender, EventArgs e)
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
    }
}
