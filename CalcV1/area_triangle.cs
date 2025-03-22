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
    public partial class area_triangle : Form
    {
        public area_triangle()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
           Form2 menuForm = new Form2();
            menuForm.Show();
            this.Hide();
        }
    }
}
