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
    public partial class EditProfile : Form
    {
        Methods fun = new Methods();
        public EditProfile()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PasswordProfile.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_ProfileName.Text == "Profile Name")
            {
                txt_ProfileName.Text = "";
            }
        }

        private void bunifuMetroTextbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Profile.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_PasswordProfile.Text == "Password")
            {
                txt_PasswordProfile.Text = "";
            }
        }

        private void bunifuMetroTextbox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pass.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_OldPass.Text == "Old Password")
            {
                txt_OldPass.Text = "";
            }
        }

        private void bunifuMetroTextbox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_repass.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_pass.Text == "Password")
            {
                txt_pass.Text = "";
            }
        }

        private void bunifuMetroTextbox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_pass.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_repass.Text == "RePassword")
            {
                txt_repass.Text = "";
            }
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            if (txt_PasswordProfile.Text == "" || txt_ProfileName.Text == "")
            {
                MessageBox.Show("Please Complite Information", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_PasswordProfile.Text != fun.getpasswordUser(User.Username))
            {
                MessageBox.Show("Encorect Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fun.ChangeProfileName(User.Username, txt_ProfileName.Text);
                MessageBox.Show("Sucssice Change Profile Name", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ProfileName.Text = "";
                txt_PasswordProfile.Text = "";
            }
        }

        private void btn_pass_Click(object sender, EventArgs e)
        {
            if (txt_OldPass.Text == "" || txt_pass.Text == "" || txt_repass.Text=="")
            {
                MessageBox.Show("Please Complite Information", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_OldPass.Text != fun.getpasswordUser(User.Username))
            {
                MessageBox.Show("incorrect Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_pass.Text != txt_repass.Text)
            {
                MessageBox.Show("Password Not Remach", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fun.changePassword(txt_pass.Text,User.Username);
                MessageBox.Show("Sucssice Change Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_repass.Text = "";
                txt_OldPass.Text = "";
                txt_pass.Text = "";
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
