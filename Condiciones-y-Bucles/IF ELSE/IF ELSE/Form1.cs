namespace IF_ELSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtValorD.Enabled = false;
            txtValorCD.Enabled = false;
        }

        private void btDescuento_Click(object sender, EventArgs e)
        {
            double valorC = double.Parse(txtValorC.Text);
            double valorF = 0;
            string txtDescuento = "";
            double descuento = 0;

            if (valorC >= 200)
            {
                txtDescuento = "15%";
                descuento = valorC * 15 / 100 ;
            }
            else if (valorC >= 150)
            {
                txtDescuento = "10%";
                descuento = valorC * 10 / 100;
            }
            else if (valorC >= 100)
            {
                txtDescuento = "5%";
                descuento = valorC * 5 / 100;
            }
            else
            {
                MessageBox.Show("No se aplica descuento");
            }

            valorF = valorC - descuento;
            txtValorD.Text = txtDescuento;
            txtValorCD.Text = valorF.ToString();
        }
    }
}
