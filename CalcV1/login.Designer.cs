namespace CalcV1
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            username_box = new TextBox();
            password_box = new TextBox();
            button1 = new Button();
            exitt_button = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(128, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(103, 139);
            label1.Name = "label1";
            label1.Size = new Size(133, 43);
            label1.TabIndex = 1;
            label1.Text = "Log In";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(74, 255);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(34, 231);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(36, 288);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(74, 316);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(243, 330);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "Clear Fields";
            label2.Click += clearFields_button;
            // 
            // username_box
            // 
            username_box.BackColor = SystemColors.ButtonFace;
            username_box.BorderStyle = BorderStyle.None;
            username_box.Location = new Point(75, 235);
            username_box.Name = "username_box";
            username_box.Size = new Size(235, 16);
            username_box.TabIndex = 8;
            username_box.TextChanged += username_box_TextChanged;
            // 
            // password_box
            // 
            password_box.BackColor = SystemColors.ButtonFace;
            password_box.BorderStyle = BorderStyle.None;
            password_box.Location = new Point(74, 296);
            password_box.Name = "password_box";
            password_box.Size = new Size(235, 16);
            password_box.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 193, 246);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(103, 368);
            button1.Name = "button1";
            button1.Size = new Size(133, 36);
            button1.TabIndex = 10;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += login_button1;
            // 
            // exitt_button
            // 
            exitt_button.AutoSize = true;
            exitt_button.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitt_button.ForeColor = SystemColors.Highlight;
            exitt_button.Location = new Point(144, 420);
            exitt_button.Name = "exitt_button";
            exitt_button.Size = new Size(46, 21);
            exitt_button.TabIndex = 11;
            exitt_button.Text = "Exit";
            exitt_button.Click += exitt_button_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(336, 480);
            Controls.Add(exitt_button);
            Controls.Add(button1);
            Controls.Add(password_box);
            Controls.Add(username_box);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button login_button;
        private Label label2;
        private Label exit_button;
        private TextBox username_box;
        private TextBox password_box;
        private Button button1;
        private Label exitt_button;
    }
}