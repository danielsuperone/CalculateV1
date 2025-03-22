namespace CalcV1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            back_button = new Button();
            search_box = new TextBox();
            search_button = new Button();
            area_button = new Button();
            perimeter_button = new Button();
            logout_button = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(258, 20);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 0;
            label1.Text = "Advanced Calculator";
            label1.Click += label1_Click;
            // 
            // back_button
            // 
            back_button.Location = new Point(12, 396);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 1;
            back_button.Text = "Back";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += button1_Click;
            // 
            // search_box
            // 
            search_box.Location = new Point(258, 60);
            search_box.Name = "search_box";
            search_box.Size = new Size(240, 23);
            search_box.TabIndex = 2;
            // 
            // search_button
            // 
            search_button.FlatStyle = FlatStyle.Flat;
            search_button.Location = new Point(504, 60);
            search_button.Name = "search_button";
            search_button.Size = new Size(75, 23);
            search_button.TabIndex = 3;
            search_button.Text = "Search";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += Search_click;
            // 
            // area_button
            // 
            area_button.Location = new Point(130, 110);
            area_button.Name = "area_button";
            area_button.Size = new Size(81, 23);
            area_button.TabIndex = 4;
            area_button.Text = "Area △";
            area_button.UseVisualStyleBackColor = true;
            area_button.Click += area_button_Click;
            // 
            // perimeter_button
            // 
            perimeter_button.Location = new Point(227, 110);
            perimeter_button.Name = "perimeter_button";
            perimeter_button.Size = new Size(81, 23);
            perimeter_button.TabIndex = 5;
            perimeter_button.Text = "Perimeter 🔲";
            perimeter_button.UseVisualStyleBackColor = true;
            perimeter_button.Click += perimeter_button_Click;
            // 
            // logout_button
            // 
            logout_button.Location = new Point(93, 396);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(75, 23);
            logout_button.TabIndex = 6;
            logout_button.Text = "Log Out";
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += logout_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(733, 9);
            label2.Name = "label2";
            label2.Size = new Size(16, 17);
            label2.TabIndex = 7;
            label2.Text = "X";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(715, 3);
            label3.Name = "label3";
            label3.Size = new Size(13, 17);
            label3.TabIndex = 8;
            label3.Text = "_";
            label3.Click += label3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 431);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(logout_button);
            Controls.Add(perimeter_button);
            Controls.Add(area_button);
            Controls.Add(search_button);
            Controls.Add(search_box);
            Controls.Add(back_button);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button back_button;
        private TextBox search_box;
        private Button search_button;
        private Button area_button;
        private Button perimeter_button;
        private Button logout_button;
        private Label label2;
        private Label label3;
    }
}