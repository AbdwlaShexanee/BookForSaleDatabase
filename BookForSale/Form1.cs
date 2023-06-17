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
    public partial class Form1 : Form
    {
        Methods fun = new Methods();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (fun.checkUser(txt_username_log.Text)==1)
            {
                MessageBox.Show("Not User");
            }
            else if (fun.login(txt_username_log.Text, txt_password_log.Text))
            {
                if (fun.getPower(txt_username_log.Text) == 0)
                {
                    MessageBox.Show("UserBlocked");
                }
                else if (fun.getPower(txt_username_log.Text) == 1)
                {
                    User.Username = txt_username_log.Text;
                    User.Password = txt_password_log.Text;
                    Hide();
                    new HomeUser().Show();
                }
                else if (fun.getPower(txt_username_log.Text) == 2)
                {
                    User.Username = txt_username_log.Text;
                    User.Password = txt_password_log.Text;
                    Hide();
                    new HomeAdmin().Show();
                }
                else if (fun.getPower(txt_username_log.Text) == 3)
                {
                    User.Username = txt_username_log.Text;
                    User.Password = txt_password_log.Text;
                    Hide();
                    new Home_Manager().Show();
                }
            }
            else
            {
                MessageBox.Show("Fail login");
            }

            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            EnterCode.Visible = false;
            ChangePassword.Visible = false;
            GetCode.Visible = false;
            Register.Visible = false;
            Loginpanel.Visible = true;
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_username_log_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password_log.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_username_log.Text == "Username")
            {
                txt_username_log.Text = "";
            }
        }

        private void txt_password_log_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_log.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_password_log.Text == "Password")
            {
                txt_password_log.Text = "";
            }
        }

        private void btn_forgetpassword_log_Click(object sender, EventArgs e)
        {
            Loginpanel.Visible = false;
            Register.Visible = false;
            EnterCode.Visible = false;
            ChangePassword.Visible = false;
            GetCode.Visible = true;
        }

        private void btn_register_log_Click(object sender, EventArgs e)
        {
            Loginpanel.Visible = false;
            EnterCode.Visible = false;
            ChangePassword.Visible = false;
            GetCode.Visible = false;
            Register.Visible = true;
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
                
                SetDesktopLocation(MousePosition.X-mousex, MousePosition.Y-mousey);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_register_reg_Click(object sender, EventArgs e)
        {
            if (txt_username_reg.Text == "")
            {
                MessageBox.Show("Please Enter Username", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_password_reg.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_repassword_reg.Text == "")
            {
                MessageBox.Show("Please Enter RePassword", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_profilename_reg.Text == "")
            {
                MessageBox.Show("Please Enter Profile Name", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_phoneNumber_reg.Text == "")
            {
                MessageBox.Show("Please Enter Phone Number", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_password_reg.Text != txt_repassword_reg.Text)
            {
                MessageBox.Show("Password Not Rematch", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (fun.checkUser(txt_username_reg.Text)==0)
            {
                MessageBox.Show("Alredy UserName Created", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                fun.register(txt_username_reg.Text, txt_password_reg.Text, txt_profilename_reg.Text, txt_phoneNumber_reg.Text);
                MessageBox.Show("Sucssice Register", "Sucssice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_username_reg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password_reg.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_username_reg.Text == "Username")
            {
                txt_username_reg.Text = "";
            }
        }

        private void txt_password_reg_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txt_repassword_reg.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_username_reg.Text == "Password")
            {
                txt_username_reg.Text = "";
            }
        }

        private void txt_repassword_reg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_profilename_reg.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_username_reg.Text == "RePassword")
            {
                txt_username_reg.Text = "";
            }
        }

        private void txt_profilename_reg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_phoneNumber_reg.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_username_reg.Text == "ProfileName")
            {
                txt_username_reg.Text = "";
            }
        }

        private void txt_phoneNumber_reg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_register_reg.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_username_reg.Text == "PhoneNumber")
            {
                txt_username_reg.Text = "";
            }
        }

        private void btn_login_entercode_Click(object sender, EventArgs e)
        {
            EnterCode.Visible = false;
            ChangePassword.Visible = false;
            GetCode.Visible = false;
            Register.Visible = false;
            Loginpanel.Visible = true;
        }

        private void btn_getcode_getcode_Click(object sender, EventArgs e)
        {
            if (txt_username_getcode.Text == "")
            {
                MessageBox.Show("Please Enter Username", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (fun.checkUser(txt_username_getcode.Text) == 1)
            {
                MessageBox.Show("Check Username", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    User.Username = txt_username_getcode.Text;
                    fun.updateRecoveryCode(txt_username_getcode.Text);
                    WebClient client = new WebClient();
                    Stream s = client.OpenRead("https://platform.clickatell.com/messages/http/send?apiKey=bRjT-F1IS1momf_fsibAuQ==&to=9647507534635&content=" + "Book For Sale"+Environment.NewLine+"Hellow Mr "+txt_username_getcode.Text+Environment.NewLine+"Code : "+fun.getrecoveryCode(txt_username_getcode.Text)+Environment.NewLine+"Best Regard");
                    StreamReader reader = new StreamReader(s);
                    Loginpanel.Visible = false;
                    Register.Visible = false;
                    GetCode.Visible = false;
                    ChangePassword.Visible = false;
                    EnterCode.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_username_getcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_getcode_getcode.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_username_getcode.Text == "Username")
            {
                txt_username_getcode.Text = "";
            }
        }

        private void btn_continue_entercode_Click(object sender, EventArgs e)
        {
            if (txt_code_entercode.Text == "")
            {
                MessageBox.Show("Please enter Code", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txt_code_entercode.Text==fun.getrecoveryCode(User.Username))
            {
                Loginpanel.Visible = false;
                Register.Visible = false;
                EnterCode.Visible = false;
                GetCode.Visible = false;
                ChangePassword.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Correct Code", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_code_entercode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_continue_entercode.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Register.Visible = false;
            EnterCode.Visible = false;
            GetCode.Visible = false;
            ChangePassword.Visible = false;
            Loginpanel.Visible = true;
        }

        private void txt_password_changepassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_repassword_changepassword.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_password_changepassword.Text == "Password")
            {
                txt_password_changepassword.Text = "";
            }
        }

        private void txt_repassword_changepassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_changepassword_changepassword.Focus();
                e.SuppressKeyPress = true;
            }
            else if (txt_repassword_changepassword.Text == "Repassword")
            {
                txt_repassword_changepassword.Text = "";
            }
        }

        private void btn_changepassword_changepassword_Click(object sender, EventArgs e)
        {
            if (txt_password_changepassword.Text != txt_repassword_changepassword.Text)
            {
                MessageBox.Show("Password Not Rematch", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_password_changepassword.Text == "")
            {
                MessageBox.Show("Please Enter password", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_repassword_changepassword.Text == "")
            {
                MessageBox.Show("Please Enter RePassword", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_password_changepassword.Text.Length < 8)
            {
                MessageBox.Show("minimum Password 8 Word", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fun.changePassword(txt_password_changepassword.Text,User.Username);
                MessageBox.Show("Sucssice Change Password", "Sucssice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_login_getcode_Click(object sender, EventArgs e)
        {
            Register.Visible = false;
            EnterCode.Visible = false;
            GetCode.Visible = false;
            ChangePassword.Visible = false;
            Loginpanel.Visible = true;
        }
    }
}
