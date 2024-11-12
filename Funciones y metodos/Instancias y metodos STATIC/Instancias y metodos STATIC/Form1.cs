namespace Instancias_y_metodos_STATIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("5 elevado a la 3era potencia es: " + Matematica.potencia(5,3));
        }
    }
}
  