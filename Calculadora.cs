namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrWhiteSpace(txtNumero1.Text) && string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Digite o primeiro e segundo número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                if (!double.TryParse(txtNumero1.Text, out double numero1) || !double.TryParse(txtNumero2.Text, out double numero2))
                {
                    MessageBox.Show("Não digite letra nos campos de texto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNumero1.Clear();
                    txtNumero2.Clear();
                }
                else
                {
                    lblResultado.Text = (numero1 + numero2).ToString();
                    txtNumero1.Clear();
                    txtNumero2.Clear();
                }
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) && string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Digite o primeiro e segundo número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!double.TryParse(txtNumero1.Text, out double numero1) || !double.TryParse(txtNumero2.Text, out double numero2))
                {
                    MessageBox.Show("Não digite letra nos campos de texto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNumero1.Clear();
                    txtNumero2.Clear();
                }
                else
                {
                    lblResultado.Text = (numero1 - numero2).ToString();
                    txtNumero1.Clear();
                    txtNumero2.Clear();
                }
            }

        }

        private void btnMultipilicar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) && string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Digite o primeiro e segundo número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!double.TryParse(txtNumero1.Text, out double numero1) || !double.TryParse(txtNumero2.Text, out double numero2))
                {
                    MessageBox.Show("Não digite letra nos campos de texto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNumero1.Clear();
                    txtNumero2.Clear();
                }
                else
                {
                    lblResultado.Text = (numero1 * numero2).ToString();
                    txtNumero1.Clear();
                    txtNumero2.Clear();
                }
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) && string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Digite o primeiro e segundo número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!double.TryParse(txtNumero1.Text, out double numero1) || !double.TryParse(txtNumero2.Text, out double numero2))
                {
                    MessageBox.Show("Não digite letra nos campos de texto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNumero1.Clear();
                    txtNumero2.Clear();
                }
                else
                {
                    lblResultado.Text = (numero1 / numero2).ToString();
                    txtNumero1.Clear();
                    txtNumero2.Clear();
                }
            }
        }

        private void Calculadora_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
