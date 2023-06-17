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
    public partial class All_Message : Form
    {
        Methods fun = new Methods();
        int id;
        public All_Message()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == ""||txt_title.Text==""||txt_message.Text=="")
            {
                MessageBox.Show("Please Select Message ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fun.deleteMessage(id);
                txt_message.Text = "";
                txt_title.Text = "";
                datashow.DataSource = fun.showAllMessage();
                MessageBox.Show("Sucssice Delete Message", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void datashow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           id =int.Parse(datashow.CurrentRow.Cells[0].Value.ToString());
           txt_username.Text= datashow.CurrentRow.Cells[1].Value.ToString();
           txt_title.Text = datashow.CurrentRow.Cells[2].Value.ToString();
           txt_message.Text = datashow.CurrentRow.Cells[3].Value.ToString();
        }

        private void All_Message_Load(object sender, EventArgs e)
        {
            datashow.DataSource = fun.showAllMessage();
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
