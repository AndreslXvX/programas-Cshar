using System.Drawing.Text;

namespace Objetos_asociados
{
    public partial class Form1 : Form
    {
        private Almacen almacen = new Almacen();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCFechaVenta.Enabled = false;
            txtCNombreCliente.Enabled = false;
            txtCTotalVenta.Enabled = false;
        }

        private void btAVenta_Click(object sender, EventArgs e)
        {
            if (txtNCliente.Text != "" && txtNombre.Text != ""
                && txtApellido.Text != "" && txtCelular.Text != ""
                && txtMVenta.Text != "")
            {
                Cliente nuevoCliente = new Cliente(txtNombre.Text, txtApellido.Text,
                    int.Parse(txtCelular.Text), int.Parse(txtNCliente.Text));

                DateTime f = DateTime.Now;
                int dia = f.Day;
                int mes = f.Month;
                int año = f.Year;
                int hora = f.Hour;
                int minuto = f.Minute;
                int sec = f.Second;

                Fecha fecha = new Fecha(dia, mes, año, hora, minuto, sec);
                almacen.añadirVenta(int.Parse(txtMVenta.Text), nuevoCliente, fecha);
                limpiearCeldas();

                MessageBox.Show("La venta se añadio con exito");

                Venta v = almacen.ConsultarUltimaVenta();
                MessageBox.Show("Realizaste la venta numero : " + v.getNumero());



            }
            else
            {
                MessageBox.Show("Hubo un error, asegurate de llenar todos los campos");
            }


        }
        private void limpiearCeldas()
        {
            txtApellido.Clear();
            txtCelular.Clear();
            txtMVenta.Clear();
            txtNCliente.Clear();
            txtNombre.Clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venta venta = null;
            if (txtNumeroVenta.Text != "")
            {
                venta = almacen.ConsultarVenta
                    (int.Parse(txtNumeroVenta.Text));
                if (venta != null)
                {
                    txtCNombreCliente.Text = venta.getCliente().getNombres();
                    txtCTotalVenta.Text = venta.getMonto().ToString();
                    txtCFechaVenta.Text = venta.getFecha().getFecha();
                }
                else
                {
                    MessageBox.Show("La venta no existe");
                }
            }
        }
    }
}

