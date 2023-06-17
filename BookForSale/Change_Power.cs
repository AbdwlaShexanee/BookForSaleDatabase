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
    public partial class Change_Power : Form
    {
        Methods fun = new Methods();
        public Change_Power()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(txt_username.Text=="" || txt_select_power!=txt_select_power.SelectedItem){
                MessageBox.Show("Please Complite all Information","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (fun.checkUser(txt_username.Text)==1)
            {
                MessageBox.Show("Username Not Found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txt_select_power.Text=="BlockUser"){
                fun.changepowerUser(txt_username.Text,0);
                MessageBox.Show("Sucssice Change Power To Block User", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(txt_select_power.Text=="NormalUser"){
                fun.changepowerUser(txt_username.Text, 1);
                MessageBox.Show("Sucssice Change Power To Normal User", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(txt_select_power.Text=="AdminUser"){
                fun.changepowerUser(txt_username.Text, 2);
                MessageBox.Show("Sucssice Change Power To Admin User", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(txt_select_power.Text=="ManagerUser"){
                fun.changepowerUser(txt_username.Text, 3);
                MessageBox.Show("Sucssice Change Power To Manager User", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_changePower.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_username.Text == "UserName")
            {
                txt_username.Text = "";
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
