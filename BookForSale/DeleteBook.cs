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
    public partial class DeleteBook : Form
    {
        int id;
        Methods fun = new Methods();
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           id=int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void DeleteBook_Load(object sender, EventArgs e)
        {
            if (fun.getPower(User.Username) == 2)
            {
                dataGridView1.DataSource = fun.showallBookUser(User.Username);
            }
            else if (fun.getPower(User.Username) == 3)
            {
               dataGridView1.DataSource= fun.showallBook();
            }
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            fun.deleteBook(id);
            if (fun.getPower(User.Username) == 2)
            {
                dataGridView1.DataSource = fun.showallBookUser(User.Username);
            }
            else if (fun.getPower(User.Username) == 3)
            {
                dataGridView1.DataSource = fun.showallBook();
            }
            MessageBox.Show("Sucssice Deleted Book", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label1_Click(object sender, EventArgs e)
        {
             if (fun.getPower(User.Username) == 2)
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
