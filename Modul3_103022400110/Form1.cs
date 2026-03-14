namespace Modul3_103022400110
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Celcius");
            comboBox1.Items.Add("Fahrenheit");
            comboBox1.Items.Add("Kelvin");
            comboBox1.Items.Add("Reamur");

            comboBox2.Items.Add("Celcius");
            comboBox2.Items.Add("Fahrenheit");
            comboBox2.Items.Add("Kelvin");
            comboBox2.Items.Add("Reamur");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu");
            } else if (textBox1.Text == "") 
            { 
                MessageBox.Show("Masukkan angka yang valid!");
            }

            // Sama satuan
            if (comboBox1.SelectedItem == comboBox2.SelectedItem)
            {
                double value = double.Parse(textBox1.Text);
                textBox2.Text = value.ToString();
            }

            // Celcius
            if (comboBox1.SelectedItem == "Celcius" && comboBox2.SelectedItem == "Fahrenheit")
            {
                double celcius = double.Parse(textBox1.Text);
                double fahrenheit = (celcius * 9 / 5) + 32;
                textBox2.Text = fahrenheit.ToString();
            } else if (comboBox1.SelectedItem == "Celcius" && comboBox2.SelectedItem == "Kelvin")
            {
                double celcius = double.Parse(textBox1.Text);
                double kelvin = celcius + 273.15;
                textBox2.Text = kelvin.ToString();
            } else if (comboBox1.SelectedItem == "Celcius" && comboBox2.SelectedItem == "Reamur")
            {
                double celcius = double.Parse(textBox1.Text);
                double reamur = 4/5 * celcius;
                textBox2.Text = reamur.ToString();
            }

            // Fahrenheit
            if (comboBox1.SelectedItem == "Fahrenheit" && comboBox2.SelectedItem == "Celcius")
            {
                double fahrenheit = double.Parse(textBox1.Text);
                double celcius = 5/9 * (fahrenheit - 32);
                textBox2.Text = celcius.ToString();
            }
            else if (comboBox1.SelectedItem == "Fahrenheit" && comboBox2.SelectedItem == "Kelvin")
            {
                double fahrenheit = double.Parse(textBox1.Text);
                double kelvin = ((fahrenheit - 32) * 5 / 9) + 273.15;
                textBox2.Text = kelvin.ToString();
            }
            else if (comboBox1.SelectedItem == "Fahrenheit" && comboBox2.SelectedItem == "Reamur")
            {
                double fahrenheit = double.Parse(textBox1.Text);
                double reamur = 4 / 9 * (fahrenheit - 32);
                textBox2.Text = reamur.ToString();
            }

            // Kelvin
            if (comboBox1.SelectedItem == "Kelvin" && comboBox2.SelectedItem == "Celcius")
            {
                double kelvin = double.Parse(textBox1.Text);
                double celcius = kelvin - 273.15;
                textBox2.Text = celcius.ToString();
            }
            else if (comboBox1.SelectedItem == "Kelvin" && comboBox2.SelectedItem == "Fahrenheit")
            {
                double kelvin = double.Parse(textBox1.Text);
                double fahrenheit = 9/5 * (kelvin - 273.15) + 32;
                textBox2.Text = fahrenheit.ToString();
            }
            else if (comboBox1.SelectedItem == "Kelvin" && comboBox2.SelectedItem == "Reamur")
            {
                double kelvin = double.Parse(textBox1.Text);
                double reamur = 4/5 * (kelvin - 273.15);
                textBox2.Text = reamur.ToString();
            }

            // Reamur
            if (comboBox1.SelectedItem == "Reamur" && comboBox2.SelectedItem == "Celcius")
            {
                double reamur = double.Parse(textBox1.Text);
                double celcius = 5/4 * reamur;
                textBox2.Text = celcius.ToString();
            }
            else if (comboBox1.SelectedItem == "Reamur" && comboBox2.SelectedItem == "Fahrenheit")
            {
                double reamur = double.Parse(textBox1.Text);
                double fahrenheit = 9/ 4 * reamur + 32;
                textBox2.Text = fahrenheit.ToString();
            }
            else if (comboBox1.SelectedItem == "Reamur" && comboBox2.SelectedItem == "Kelvin")
            {
                double reamur = double.Parse(textBox1.Text);
                double kelvin = 5/4 * reamur + 273.15;
                textBox2.Text = kelvin.ToString();
            }
        }
    }
}
