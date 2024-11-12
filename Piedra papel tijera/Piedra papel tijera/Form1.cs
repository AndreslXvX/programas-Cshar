using System.Text.Json.Serialization;

namespace Piedra_papel_tijera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Random random = new();
        private readonly Jugadores jugador1 = new(" ", 0);
        private readonly Jugadores CPU = new(" ", 0);
        private readonly Combates combate = new();

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnPiedra_Click(object sender, EventArgs e)
        {
            jugador1.JUGADA = BtnPiedra.Text;
            LblJugador.Text = jugador1.JUGADA;
            EleccionCPU(random.Next(1, 4));
            EmpezarCombate();
        }

        private void BtnPapel_Click(object sender, EventArgs e)
        {
            jugador1.JUGADA = BtnPapel.Text;
            LblJugador.Text = jugador1.JUGADA;
            EleccionCPU(random.Next(1, 4));
            EmpezarCombate();
        }

        private void BtnTijera_Click(object sender, EventArgs e)
        {
            jugador1.JUGADA = BtnTijera.Text;
            LblJugador.Text = jugador1.JUGADA;
            EleccionCPU(random.Next(1, 4));
            EmpezarCombate();

        }
        public void EleccionCPU(int i)
        {
            if (i == 1) { CPU.JUGADA = "piedra"; }
            else if (i == 2) { CPU.JUGADA = "papel"; }
            else { CPU.JUGADA = "tijera"; }
            LblCPU.Text = CPU.JUGADA;
        }
        public void EmpezarCombate()
        {
            combate.Combate(jugador1, CPU);
            ActualizarDatos();
            
        }
        public void ActualizarDatos()
        {
            LblGanador.Text = combate.RESULTADO.ToString();
            LblRondas.Text = combate.RONDAS.ToString();
            LblVictoriasJugador.Text = jugador1.VICTORIAS.ToString();
            LblVictoriasCPU.Text = CPU.VICTORIAS.ToString();
        }

    }
}
