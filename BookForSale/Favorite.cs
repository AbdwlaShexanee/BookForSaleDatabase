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
    public partial class Favorite : Form
    {
        Methods fun = new Methods();
        public Favorite()
        {
            InitializeComponent();
        }

        private void Favorite_Load(object sender, EventArgs e)
        {
           datashow.DataSource=fun.showallFavorite(User.Username);
           label_profilename.Text = fun.getprofileName(User.Username);
           label_usercoin.Text = fun.getCoinUser(User.Username).ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btn_addtofavarite_Click(object sender, EventArgs e)
        {
            if (fun.id =="")
            {
                MessageBox.Show("Please Select Book", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                fun.UnFavorite(fun.id);
                datashow.DataSource = fun.showallFavorite(User.Username);
                Bookimage.BackgroundImage = null;
                MessageBox.Show("Sucssice UnFavaret", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_search_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.Equals(""))
            {
                datashow.DataSource = fun.SearchFavorite(User.Username,txt_search.Text);
            }
            else if (fun.SearchFavorite(User.Username, txt_search.Text).Rows.Count < 1)
            {
                datashow.DataSource = fun.SearchFavorite(User.Username, txt_search.Text);
                MessageBox.Show("Not Found", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                datashow.DataSource = fun.SearchFavorite(User.Username, txt_search.Text);
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
                fun.buyBook(User.Username, fun.title, fun.namecreated, fun.yearscreated, fun.language, fun.pageNumber, fun.cost, fun.image, url);
                MessageBox.Show("Sucssice Buy Book ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label_usercoin.Text = fun.getCoinUser(User.Username).ToString();
            }
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
            else if (txt_search.Text == "Search")
            {
                txt_search.Text = "";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            if(fun.getPower(User.Username)==1){
                Hide();
                new HomeUser().Show();
            }else if(fun.getPower(User.Username)==2){
                Hide();
                new HomeAdmin().Show();
            }else if(fun.getPower(User.Username)==3){
                Hide();
                new Home_Manager().Show();
            }

        }

        }
    }

