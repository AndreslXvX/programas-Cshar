namespace Programacion_orientada_a_objetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Aire_Acondicionado aire1 = new Aire_Acondicionado("lala", "lala1", "blanco", 10, 20, 16);
            Aire_Acondicionado aire2 = new Aire_Acondicionado("yakult", "yakult1", "amarillo", 20, 30, 16);

            aire2.SubirTemperatura(10);

            MessageBox.Show("la temperatura del aire2 es de " + aire2.getTemperatura());

        }
    }
}
