namespace CalcV1
{
    partial class area_triangle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(area_triangle));
            back_button = new Button();
            SuspendLayout();
            // 
            // back_button
            // 
            back_button.Location = new Point(12, 336);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 2;
            back_button.Text = "Back";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // area_triangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 371);
            Controls.Add(back_button);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "area_triangle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "area_triangle";
            ResumeLayout(false);
        }

        #endregion

        private Button back_button;
    }
}