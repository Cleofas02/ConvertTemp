using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double inputTemp;
            bool isValid = double.TryParse(textBox1.Text, out inputTemp);

            if (!isValid)
            {
                textBox2.Text = "Invalid number!";
                return;
            }

            string selectedConversion = comboBox1.SelectedItem?.ToString();
            string unit = "";
            double result = 0; // Declare result before using it

            // Switch case logic for temperature conversion
            switch (selectedConversion)
            {
                case "Celsius to Fahrenheit":
                    result = (inputTemp * 9 / 5) + 32;
                    unit = "°F";
                    break;

                case "Fahrenheit to Celsius":
                    result = (inputTemp - 32) * 5 / 9;
                    unit = "°C";
                    break;

                case "Fahrenheit to Kelvin":
                    result = (inputTemp - 32) * 5 / 9 + 273.15;
                    unit = "K";
                    break;

                case "Kelvin to Fahrenheit":
                    result = (inputTemp - 273.15) * 9 / 5 + 32;
                    unit = "°F";
                    break;

                case "Celsius to Kelvin":
                    result = inputTemp + 273.15;
                    unit = "K";
                    break;

                case "Kelvin to Celsius":
                    result = inputTemp - 273.15;
                    unit = "°C";
                    break;

                default:
                    textBox2.Text = "Please select a conversion type.";
                    return;
            }

            // Display the result in textBox2
            textBox2.Text = $"{result:F2} {unit}";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
