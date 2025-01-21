using System.Diagnostics.Eventing.Reader;

namespace CalculadoraPro
{
    public partial class Form1 : Form
    {
        // variables globales
        private double valor1;
        private double valor2;
        private double resultado;

        private int operacion; // bandera

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
            operacion = 1; // bandera
            valor1 = Convert.ToDouble(textBox_Pantalla.Text); // guardar el valor en la variable valor1
            textBox_Pantalla.Text = ""; // vaciar pantalla

        }

        private void button_resta_Click(object sender, EventArgs e)
        {
            operacion = 2; // bandera
            valor1 = Convert.ToDouble(textBox_Pantalla.Text); // guardar el valor en la variable valor1
            textBox_Pantalla.Text = ""; // vaciar pantalla
        }

        private void button_multiplicar_Click(object sender, EventArgs e)
        {
            operacion = 3; // bandera
            valor1 = Convert.ToDouble(textBox_Pantalla.Text); // guardar el valor en la variable valor1
            textBox_Pantalla.Text = ""; // vaciar pantalla
        }

        private void button_dividir_Click(object sender, EventArgs e)
        {
            operacion = 4; // bandera
            valor1 = Convert.ToDouble(textBox_Pantalla.Text); // guardar el valor en la variable valor1
            textBox_Pantalla.Text = ""; // vaciar pantalla
        }
        private void button_punto_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += ".";
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

            valor2 = Convert.ToDouble(textBox_Pantalla.Text); // guardar el valor en la variable valor2

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;

                case 2:

                    if (valor1 < valor2)
                    {
                        MessageBox.Show("Error, el primero valor de una resta debe ser mayor que el segundo valor");
                    }
                    else if (valor2 == 0)
                    {
                        MessageBox.Show("Error, el segundo valor de una resta no puede ser 0");
                    }
                    else
                    {
                        resultado = valor1 - valor2;
                    }
                    break;

                case 3:
                    resultado = valor1 * valor2;
                    break;

                case 4:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("Error: El segundo valor de una division no puede ser 0");
                        textBox_Pantalla.Text = "";
                    }
                    else if (valor1 < valor2)
                    {
                        MessageBox.Show("Error: el primer valor de una division debe ser mayor que el segundo valor");
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;

                default:
                    MessageBox.Show("Error");
                    break;
            }

            // el resultado debe ir fuera del switch
            if (operacion == 1)
            {
                textBox_Pantalla.Text = (valor1 + " + " + valor2 + " = " + resultado.ToString());
            }
            else if (operacion == 2)
            {
                textBox_Pantalla.Text = (valor1 + " - " + valor2 + " = " + resultado.ToString());
            }
            else if (operacion == 3)
            {
                textBox_Pantalla.Text = (valor1 + " * " + valor2 + " = " + resultado.ToString());
            }
            else if (operacion == 4)
            {
                textBox_Pantalla.Text = (valor1 + " ÷ " + valor2 + " = " + resultado.ToString());
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

    }
}
