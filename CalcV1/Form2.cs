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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menuForm = new Form1();
            menuForm.Show();
            this.Hide(); // Optional: hides the main form
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_click(object sender, EventArgs e)
        {
            string searchQuery = search_box.Text.ToLower(); // takes search from box and puts in lower case (compatability)

            if (searchQuery.Contains("area")) //search button for area △
            {
                area_triangle menuForm = new area_triangle();
                menuForm.Show();
                this.Hide();
            }
            else if (searchQuery.Contains("perimeter")) // search utility for perimter
            {
                perimeter menuForm = new perimeter();
                menuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No matching feature found."); //else if not found
            }
        }

        private void area_button_Click(object sender, EventArgs e)
        {
            area_triangle menuForm = new area_triangle();
            menuForm.Show();
            this.Hide();
        }

        private void perimeter_button_Click(object sender, EventArgs e)
        {
            perimeter menuForm = new perimeter();
            menuForm.Show();
            this.Hide();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            login menuForm = new login();
            menuForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
