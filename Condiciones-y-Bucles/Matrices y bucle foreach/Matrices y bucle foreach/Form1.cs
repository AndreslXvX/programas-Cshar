namespace Matrices_y_bucle_foreach
{
    public partial class Form1 : Form
    {

        string[,] producto = new string[4, 3];

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            txtNombreProducto.Enabled = false;
            txtPrecio.Enabled = false;



            producto[0, 0] = "Codigo";
            producto[0, 1] = "Comida";
            producto[0, 2] = "Precio";

            producto[1, 0] = "P001";
            producto[2, 0] = "P002";
            producto[3, 0] = "P003";

            producto[1, 1] = "Arroz";
            producto[2, 1] = "Lentejas";
            producto[3, 1] = "aceite";

            producto[1, 2] = "20";
            producto[2, 2] = "30";
            producto[3, 2] = "40";
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

            string codigo = txtCodigo.Text.ToUpper();
            bool vEncontrado = false;
            int posicion = 0;

            for (int i = 0; i < producto.Length && vEncontrado == false; i++)
            {
                if (producto[i,0] == codigo)
                {
                    vEncontrado = true;
                    posicion = i;
                }

            }
            if (vEncontrado)
            {
                txtNombreProducto.Text = producto[posicion, 1];
                txtPrecio.Text = producto[posicion, 2];
            }
            else
            {
                MessageBox.Show("No se encontro el producto");
            }
        }
    }
}
