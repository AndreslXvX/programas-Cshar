namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Clientes> clientes = new List<Clientes>();

            clientes.

            foreach (Clientes i in clientes)
            {
                MessageBox.Show(i.Nombre);
            }

            clientes.Add(new Clientes("Andres", "Conde", "Campo real", "18", "55555", 5));
            clientes.Add(new Clientes("Luis", "Conde", "Campo real2", "4", "44444", 50));
            clientes.Add(new Clientes("Juan", "Conde", "Campo real3", "11", "66666", 500));

        }
    }
}
