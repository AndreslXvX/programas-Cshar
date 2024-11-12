namespace Practica_con_FOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ltMultiplicar.Enabled = false;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            for (int i = 1; i <= 10; i++)
            {
                ltMultiplicar.Items.Add(numero + "X" + i + "=" + (numero * i));
            }
        }
    }
}
