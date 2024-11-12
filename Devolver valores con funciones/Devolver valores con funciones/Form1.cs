namespace Devolver_valores_con_funciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btCalcular_Click(object sender, EventArgs e)
        {
            double totalDescuento = CalcularDescuento(double.Parse(txtPrecio.Text));
            double totalNeto = double.Parse(txtPrecio.Text) - totalDescuento;

            txtDescuento.Text = totalDescuento.ToString();
            txtTotal.Text = totalNeto.ToString();
        }

        public double CalcularDescuento(double totalCompra)
        {
            double descuento = 0;
            if (totalCompra > 100 && totalCompra <= 200)
            {
                descuento = totalCompra * 0.05;
            }
            else if (totalCompra > 200 && totalCompra <= 300)
            {
                descuento = totalCompra * 0.1;
            }
            else if (totalCompra > 300)
            {
                descuento = totalCompra * 0.2;
            }

            return descuento;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDescuento.Enabled = false;
            txtTotal.Enabled = false;

        }
    }
}
