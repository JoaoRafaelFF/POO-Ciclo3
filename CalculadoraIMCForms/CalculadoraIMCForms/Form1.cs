using System.Web;
using System.Globalization;

namespace CalculadoraIMCForms
{
    public partial class lbl_Tutulo1 : Form
    {
        public lbl_Tutulo1()
        {
            InitializeComponent();
            btm_Calcular.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btm_Calcular_Click(object sender, EventArgs e)
        {
            double.TryParse(text_Altura.Text, out double altura);
            if (altura == null) return;

            double.TryParse(text_Peso.Text, out double peso);
            if (peso == null) return;

            double IMC;
            string classificacao;

            IMC = peso / (altura * altura);

            if (IMC < 17)
            {
                classificacao = "Muito abaixo do peso";
            }
            else if (IMC >= 17 && IMC <= 18.49)
            {
                classificacao = "Abaixo do peso";
            }
            else if (IMC >= 18.50 && IMC <= 24.99)
            {
                classificacao = "Peso normal";
            }
            else if (IMC >= 25 && IMC <= 29.99)
            {
                classificacao = "Acima do peso";
            }
            else if (IMC >= 30 && IMC <= 34.99)
            {
                classificacao = "Obesidade I";
            }
            else if (IMC >= 35 && IMC <= 39.99)
            {
                classificacao = "Obesidade II";
            }
            else
            {
                classificacao = "Obesidade III";
            }

            string Aviso = "o seu imc é: " + IMC.ToString("##.##") + " e sua classificacão é: " + classificacao.ToString();

            MessageBox.Show(Aviso);

        }

        private void text_Altura_TextChanged(object sender, EventArgs e)
        {
            btm_Calcular.Enabled = text_Altura.Text != "" ? true : false;
        }

        private void text_Peso_TextChanged(object sender, EventArgs e)
        {
            btm_Calcular.Enabled = text_Peso.Text != "" ? true : false;
        }
    }
}