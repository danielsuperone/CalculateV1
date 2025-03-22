using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Runtime.CompilerServices;

namespace CalcV1
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOpenartionPerformned = false;
        private bool isPinned = false;
        public Form1()
        {
            InitializeComponent();
            InitializePinButton();
        }
        private void label1_Click(object sender, EventArgs e)
        {

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

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button15.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOpenartionPerformned = true;

            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(result_boxx.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOpenartionPerformned = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result_boxx.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result_boxx.Text = "0";
            resultValue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    result_boxx.Text = (resultValue + double.Parse(result_boxx.Text)).ToString();
                    break;
                case "-":
                    result_boxx.Text = (resultValue - double.Parse(result_boxx.Text)).ToString();
                    break;
                case "*":
                    result_boxx.Text = (resultValue * double.Parse(result_boxx.Text)).ToString();
                    break;
                case "/":
                    result_boxx.Text = (resultValue / double.Parse(result_boxx.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(result_boxx.Text);
            labelCurrentOperation.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            login menuForm = new login();
            menuForm.Show();
            this.Hide();
        }

        private void InitializePinButton()
        {
            // Set the button properties before updating the image
            pin_button.ImageAlign = ContentAlignment.MiddleCenter; // Center the image
            pin_button.AutoSize = false; // Disable AutoSize to maintain a fixed button size
            pin_button.FlatStyle = FlatStyle.Flat; // Set the button style
            pin_button.BackColor = Color.Transparent; // Ensure the background does not obscure the image
            pin_button.Size = new Size(20, 20); // Adjust the size as needed

            // Set the initial image based on the pinned state
            Image image = isPinned ? Properties.Resources.unpinned : Properties.Resources.pinned;
            Image resizedImage = ResizeImage(image, pin_button.Width - 10, pin_button.Height - 10);

            // Set the resized image to the button
            pin_button.Image = resizedImage;

            // Clear the button text after setting the image
            pin_button.Text = "";

            // Refresh the button to apply changes
            pin_button.Refresh();
        }
        private void pin_click(object sender, EventArgs e)
        {
            isPinned = !isPinned;
            this.TopMost = isPinned;

            // Resize the image to fit the button
            Image image = isPinned ? Properties.Resources.unpinned : Properties.Resources.pinned;
            Image resizedImage = ResizeImage(image, pin_button.Width - 10, pin_button.Height - 10);

            // Set the resized image to the button
            pin_button.Image = resizedImage;

            // Refresh the button to apply changes
            pin_button.Refresh();
        }


        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void result_boxx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}