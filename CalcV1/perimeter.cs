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
    public partial class perimeter : Form
    {
        bool isOpenartionPerformned = false;
        Double resultValue = 0;
        public perimeter()
        {

            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((result_boxx.Text == "0") || (isOpenartionPerformned))
                result_boxx.Clear();
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!result_boxx.Text.Contains("."))
                    result_boxx.Text = result_boxx.Text + button.Text;
            }
            else
                result_boxx.Text = result_boxx.Text + button.Text;
            isOpenartionPerformned = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            result_boxx.Text = "0";
            resultValue = 0;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form2 menuForm = new Form2();
            menuForm.Show();
            this.Hide();
        }
    }
}
