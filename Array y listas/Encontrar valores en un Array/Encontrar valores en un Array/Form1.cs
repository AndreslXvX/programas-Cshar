namespace Encontrar_valores_en_un_Array
{
    public partial class Form1 : Form
    {

        public string[] nombres = new string[3] { "Andres", "juan", "luis" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            bool encuentra = false;
            int posicion = 0;

            for (int i = 0; i < nombres.Length && encuentra == false; i++)
            {
                if (nombre == nombres[i])
                {
                    encuentra = true;
                    posicion = i;
                }

            }
            if (encuentra)
            {
                txtPosicion.Text = "Se encontro a " + nombre + " en la posicion " + posicion;
            }
            else
            {
                MessageBox.Show("No se encontro");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPosicion.Enabled = false;
        }
    }
}
