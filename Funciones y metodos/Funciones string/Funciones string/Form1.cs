namespace Funciones_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btSubstring_Click(object amen, EventArgs ei)
        {
            String palabra = txtPalabra.Text.Substring(0, 4);
            txtFuncion.Text = palabra;
        }

        private void btToUpper_Click(object seasdsadnder, EventArgs i)
        {
            String palabra = txtPalabra.Text.ToUpper();
            txtFuncion.Text = palabra;
        }

        private void btToLower_Click(object hola, EventArgs ie)
        {
            String palabra = txtPalabra.Text.ToLower();
            txtFuncion.Text = palabra;
        }
    }
}
