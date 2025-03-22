using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcV1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void login_button1(object sender, EventArgs e)
        {
            if (username_box.Text == "admin" && password_box.Text == "admin")
            {
                Form2 menuForm = new Form2();
                menuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrent Log In Details");
            }
        }
        private void clearFields_button(object sender, EventArgs e)
        {
            username_box.Text = "";
            password_box.Text = "";
        }

        private void exitt_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
