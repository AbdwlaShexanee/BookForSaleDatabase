using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace BookForSale
{
    public partial class Download : Form
    {
        Methods fun = new Methods();
        WebClient wc = new WebClient();

        public Download()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
               fun.url= fun.GetUrl(fun.title, fun.namecreated, fun.cost);
                Bookimage.BackgroundImage = Image.FromStream(fun.byteToimage(fun.image));
                Bookimage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_buybook_Click(object sender, EventArgs e)
        {
            try
            {
                if (fun.title == "")
                {

                }
                else
                {
                    wc.DownloadFile(fun.url, "C:/users/" + Environment.UserName + "/Downloads/Book For Sale/" + fun.title + ".pdf");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Error in URL Please Send This Name Book For Manager", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

      
        
        private void FileComplite(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File Download Complited ", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Download_Load(object sender, EventArgs e)
        {
           datashow.DataSource= fun.showallDownload(User.Username);
        }

        private void txt_search_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                datashow.DataSource = fun.showallDownload(User.Username);
            }
            else if (fun.SearchFavorite(User.Username, txt_search.Text).Rows.Count <1)
            {
                datashow.DataSource = fun.SearchDownload(txt_search.Text, User.Username);
                MessageBox.Show("Not Found", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                datashow.DataSource = fun.SearchDownload(txt_search.Text, User.Username);
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists("C:/users/" + Environment.UserName + "Downloads/Book For Sale") == false)
            {
                System.IO.Directory.CreateDirectory("C:/users/" + Environment.UserName + "/Downloads/Book For Sale");
                System.Diagnostics.Process.Start("C:/users/" + Environment.UserName + "/Downloads/Book For Sale");
            }            
        }

        
    }
}
