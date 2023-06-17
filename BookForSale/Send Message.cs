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
    public partial class Send_Message : Form
    {
        Methods fun = new Methods();
        public Send_Message()
        {
            InitializeComponent();
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
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (txt_title.Text == "" || txt_message.Text=="")
            {
                MessageBox.Show("Please Type All Title And Message", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fun.sendMessage(User.Username, txt_title.Text, txt_message.Text);
                txt_message.Text = "";
                txt_title.Text = "";
                MessageBox.Show("Sucssice Send Message", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
