namespace Tipos_enumerados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente cliente1 = new Cliente("Andres", "conde", "001", "55555", Cliente.tipoDeCliente.normal);

            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(new Cliente("Andres", "Conde", "001", "55555", Cliente.tipoDeCliente.normal));
            clientes.Add(new Cliente("Juan", "Conde", "002", "44444", Cliente.tipoDeCliente.premium));
            clientes.Add(new Cliente("Luis", "Conde", "003", "77777", Cliente.tipoDeCliente.normal));

            clientes.Insert(0, new Cliente("Loryn", "Alvarez", "004", "33333", Cliente.tipoDeCliente.premium));
            clientes.Insert(0, new Cliente("Andres", "Enrique", "005", "88888", Cliente.tipoDeCliente.normal));
            clientes.Clear();
        }
    }
}
