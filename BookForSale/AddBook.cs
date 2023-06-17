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
    public partial class AddBook : Form
    {
        Methods fun = new Methods();
        public AddBook()
        {
            InitializeComponent();
        }

        private void txt_title_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_namecreated.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_namecreated_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_years_created.Focus();
                e.SuppressKeyPress = true;
            }
        }


        private void Language_Enter(object sender, EventArgs e)
        {
           
                txt_catagories.Focus();
        }            
        

        private void txt_catagories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pageNumber.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_pageNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Cost.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_Cost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_URL.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_URL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Browse.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void Language_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog of=new OpenFileDialog();
            of.Filter="JPG|*.jpg|PNG|*.png";
            
            if (of.ShowDialog() == DialogResult.OK)
            {
                imageBook.BackgroundImage = new Bitmap(of.FileName);
                fun.image = fun.filetobyte(of.FileName);
            }

        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            if (txt_catagories.Text == "" || txt_Cost.Text == "" || txt_language.Text == "" || txt_namecreated.Text == "" || txt_pageNumber.Text == "" || txt_title.Text == "" || txt_URL.Text == "" || txt_years_created.Text == "" ||fun.image==null)
            {
                MessageBox.Show("Please Complite All Information","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }else{
                fun.AddBook(User.Username, txt_title.Text, txt_namecreated.Text, txt_years_created.Text, txt_language.Text, txt_pageNumber.Text, txt_Cost.Text, fun.image, txt_URL.Text);
                MessageBox.Show("Sucssice Added Book", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
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
