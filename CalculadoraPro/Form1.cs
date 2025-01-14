namespace CalculadoraPro
{
    public partial class Form1 : Form
    {
       private double valor1;
       private double valor2;

       private double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text = "";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // no tocar
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "9";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "0";
        }

        private void button_suma_Click(object sender, EventArgs e)
        {  
          valor1 = Convert.ToDouble(textBox_Pantalla.Text);
          textBox_Pantalla.Text = ""; // vaciar
        }

        private void button_igual_Click(object sender, EventArgs e)
        {
            /*

            // string val1 = textBox_Pantalla.Text;
            // string val2 = textBox_Pantalla.Text;

            // double resultado = 0;
            // double num1 = 0;
            // double num2 = 0;

            // num1 = Convert.ToDouble(val1);
            // num2 = Convert.ToDouble(val2);

            // resultado = (num1 + num2);

            // textBox_Pantalla.Text = resultado.ToString();
            */
            valor2 = Convert.ToDouble(textBox_Pantalla.Text);

            resultado = (valor1 + valor2);

            textBox_Pantalla.Text = resultado.ToString();
        }
    }
}
