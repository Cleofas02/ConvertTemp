namespace WinFormsApp3
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
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 45F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Khaki;
            label1.Image = Properties.Resources.dark_hexagonal_background_with_gradient_color_79603_1410;
            label1.Location = new Point(92, 32);
            label1.Name = "label1";
            label1.Size = new Size(623, 75);
            label1.TabIndex = 0;
            label1.Text = "Temperature Converter";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 141);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Input Value";
            textBox1.Size = new Size(444, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Celsius to Fahrenheit", "Fahrenheit to Celsius", "Fahrenheit to Kelvin", "Kelvin to Fahrenheit", "Celsius to Kelvin", "Kelvin to Celsius" });
            comboBox1.Location = new Point(286, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Select Convertion";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Khaki;
            button1.Image = Properties.Resources.dark_hexagonal_background_with_gradient_color_79603_1410;
            button1.Location = new Point(286, 263);
            button1.Name = "button1";
            button1.Size = new Size(229, 59);
            button1.TabIndex = 3;
            button1.Text = "CALCULATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 373);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Output Value";
            textBox2.Size = new Size(444, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dark_hexagonal_background_with_gradient_color_79603_1410;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Temperature Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox2;
    }
}
