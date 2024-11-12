namespace Funciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Sumar(int num1, int num2)
        {
            int resultado = num1 + num2;
            MessageBox.Show("El resultado es " + resultado);
        }
        private void btCalcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtNum1.Text);
            int numero2 = int.Parse(txtNum2.Text);

            Sumar(numero1, numero2);
        }
    }
}
