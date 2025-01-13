namespace CalculadoraPro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button_1 = new Button();
            button_2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(518, 115);
            textBox1.TabIndex = 0;
            // 
            // button_1
            // 
            button_1.Location = new Point(75, 188);
            button_1.Name = "button_1";
            button_1.Size = new Size(77, 59);
            button_1.TabIndex = 1;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = true;
            // 
            // button_2
            // 
            button_2.Location = new Point(184, 188);
            button_2.Name = "button_2";
            button_2.Size = new Size(72, 59);
            button_2.TabIndex = 2;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(294, 188);
            button1.Name = "button1";
            button1.Size = new Size(75, 59);
            button1.TabIndex = 3;
            button1.Text = "3";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 594);
            Controls.Add(button1);
            Controls.Add(button_2);
            Controls.Add(button_1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalculadoraPro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button_1;
        private Button button_2;
        private Button button1;
    }
}
