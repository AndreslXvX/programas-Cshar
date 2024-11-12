namespace Bucle_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            int numeros = int.Parse(txtNumerosMensajes.Text);

            while (numeros > 0)
            {
                ltMensajes.Items.Add("Mensaje # " + numeros);
                numeros--;
            }
        }
    }
}
