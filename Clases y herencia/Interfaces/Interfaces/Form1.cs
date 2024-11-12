namespace Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Deportista deportista1 = new Basquetbolista("Andres", "posicion1", 18, 1.60);
        }

    }
}
