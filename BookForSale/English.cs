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
    public partial class English : Form
    {
        Methods fun = new Methods();
        string Language = "English";
        public English()
        {
            InitializeComponent();
        }

        private void btn_addtofavarite_Click(object sender, EventArgs e)
        {
            if (fun.title == "")
            {
                MessageBox.Show("Please Select Book", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fun.alredyaddedToFavorite(User.Username, fun.title, fun.namecreated, fun.language) == 1)
            {
                MessageBox.Show("Alredy Added To Favarite", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fun.AddFavariteBook(User.Username, fun.title, fun.namecreated, fun.yearscreated, fun.language, fun.pageNumber, fun.cost, fun.image);
                MessageBox.Show("Sucssice Add To Favarite", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_buybook_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt_nrxekteb.Text) > int.Parse(label_usercoin.Text))
            {
                MessageBox.Show("Charge Account ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fun.alredyBuyBook(User.Username, fun.title, fun.namecreated, fun.cost).Rows.Count > 0)
            {
                MessageBox.Show("Alredy Buy Book ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int num1 = int.Parse(txt_nrxekteb.Text);
                int num2 = int.Parse(label_usercoin.Text);
                int result = num2 - num1;
                fun.updatecoin(User.Username, result.ToString());
                string url = fun.GetUrl(fun.title, fun.namecreated, fun.cost);
                fun.buyBook(User.Username, fun.title, fun.namecreated, fun.yearscreated, Language, fun.pageNumber, fun.cost, fun.image, url);
                MessageBox.Show("Sucssice Buy Book ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label_usercoin.Text = fun.getCoinUser(User.Username).ToString();
            }
        }

        private void btn_refreash_Click(object sender, EventArgs e)
        {
            datashow.DataSource = fun.showAllBookByLanguage(Language);
        }

        private void datashow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datashow.CurrentRow.Cells[0].Value.ToString() == null)
            {

            }
            else
            {
                fun.id = datashow.CurrentRow.Cells[0].Value.ToString();
                fun.title = datashow.CurrentRow.Cells[1].Value.ToString();
                fun.namecreated = datashow.CurrentRow.Cells[2].Value.ToString();
                fun.yearscreated = datashow.CurrentRow.Cells[3].Value.ToString();
                fun.language = datashow.CurrentRow.Cells[4].Value.ToString();
                fun.pageNumber = datashow.CurrentRow.Cells[5].Value.ToString();
                fun.cost = datashow.CurrentRow.Cells[6].Value.ToString();
                fun.image = (byte[])datashow.CurrentRow.Cells[7].Value;
                Bookimage.BackgroundImage = Image.FromStream(fun.byteToimage(fun.image));
                Bookimage.SizeMode = PictureBoxSizeMode.StretchImage;
                txt_nrxekteb.Text = fun.cost;
            }
        }

        private void txt_search_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                datashow.DataSource = fun.showAllBookByLanguage(Language);
            }
            else if (fun.searchBook(Language, txt_search.Text).Rows.Count < 1)
            {
                datashow.DataSource = fun.searchBook(Language, txt_search.Text);
                MessageBox.Show("Not Found", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                datashow.DataSource = fun.searchBook(Language, txt_search.Text);
            }
        }

        private void English_Load(object sender, EventArgs e)
        {
            datashow.DataSource = fun.showAllBookByLanguage(Language);
            label_profilename.Text = fun.getprofileName(User.Username);
            label_usercoin.Text = fun.getCoinUser(User.Username).ToString();
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

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_search.Text == "Search")
            {
                txt_search.Text = "";
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
