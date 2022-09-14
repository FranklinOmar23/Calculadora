namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumeros(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (textResultado.Text == "0")
                textResultado.Text = "";

            textResultado.Text += boton.Text;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(textResultado.Text);

            if (operador == '+')
            {
                textResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Text);
            }
            else if (operador == '-')
            {
                textResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Text);
            }
            else if (operador == 'X')
            {
                textResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Text);
            }
            else if (operador == '/')
            {
                textResultado.Text = (Numero1 / Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Text);
            }
        }

        private void borrar_unoA_uno_Click(object sender, EventArgs e)
        {
            if(textResultado.Text.Length > 1)
            {
                textResultado.Text = textResultado.Text.Substring(0, textResultado.Text.Length - 1);
            }
            else
            {
                textResultado.Text = "0";
            }
        }

        private void borrarTodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            operador = '\0';
            textResultado.Text = "0";
        }

        private void borraruno_Click(object sender, EventArgs e)
        {
            textResultado.Text = "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!textResultado.Text.Contains(".")) ;
            {
                textResultado.Text += ".";
            }
        }

        private void btnMas_Menos_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(textResultado.Text);
            Numero1 *= -1;
            textResultado.Text = Numero1.ToString();
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            operador = Convert.ToChar(boton.Tag);
            Numero1 = Convert.ToDouble(textResultado.Text);

            if (operador == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                textResultado.Text = Numero1.ToString();
            }
            else if (operador == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                textResultado.Text = Numero1.ToString();
            }
            else
            {
                textResultado.Text = "0";
            }
        }  
    }
}