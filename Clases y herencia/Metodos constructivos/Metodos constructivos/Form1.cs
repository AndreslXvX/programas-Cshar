namespace Metodos_constructivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Aire_Acondicionado1 aire1 = new Aire_Acondicionado1("lala", "lala1", "blanco", 10, 20, 30);
            Aire_Acondicionado1 aire2 = new Aire_Acondicionado1("yakult", "yakult1", "amarillo", 20, 30, 40);

            MessageBox.Show("La marca del aire1 es " + aire1);
            
        }
    }
}
