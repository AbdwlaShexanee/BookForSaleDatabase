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
    public partial class Cart5000 : Form
    {
        Methods fun = new Methods();
        public Cart5000()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                Stream s = client.OpenRead("https://platform.clickatell.com/messages/http/send?apiKey=bRjT-F1IS1momf_fsibAuQ==&to=9647507534635&content=" + "Book For Sale" + Environment.NewLine + "Hellow Mr " + txt_username.Text + Environment.NewLine +"Type Cart 5000"+Environment.NewLine+ "Cart Number : " + txt_CartNumber.Text + Environment.NewLine + "Best Regard");
                StreamReader reader = new StreamReader(s);
                fun.sendedCart5000(txt_CartNumber.Text);
                MessageBox.Show("Sucssice Send Cart", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CartNumber.Text = "";
                txt_username.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_refreash_Click(object sender, EventArgs e)
        {
            datashow.DataSource = fun.showCart5000();
        }

        private void datashow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          txt_CartNumber.Text=datashow.CurrentRow.Cells[1].Value.ToString();
        }

        private void Cart5000_Load(object sender, EventArgs e)
        {
            datashow.DataSource = fun.showCart5000();
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CartNumber.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_username.Text == "Username")
            {
                txt_username.Text = "";
            }
        }

        private void txt_CartNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_send.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_CartNumber.Text == "Cart Number")
            {
                txt_CartNumber.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
            new Home_Manager().Show();
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
