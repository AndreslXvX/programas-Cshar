namespace Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random Naleatorio = new Random();

        string resultado = "";
        int rondas = 0;
        int victoriasJ = 0;
        int victoriasCPU = 0;


        private void BtnPiedra_Click(object sender, EventArgs e)
        {
            LblEleccionJugador.Text = "piedra";
            Combate(1, Naleatorio.Next(1, 4));
        }
        private void BtnPapel_Click(object sender, EventArgs e)
        {
            LblEleccionJugador.Text = "papel";
            Combate(2, Naleatorio.Next(1, 4));
        }

        private void BtnTijera_Click(object sender, EventArgs e)
        {
            LblEleccionJugador.Text = "tijera";
            Combate(3, Naleatorio.Next(1, 4));
        }
        private void Combate(int valorJ, int valorCPU)
        {
            if (valorJ == 1 && valorCPU == 3 || valorJ == 2 && valorCPU == 1 ||
                valorJ == 3 && valorCPU == 2)
            {
                resultado = "Ganaste";
                LblResultado.Text = resultado;
                victoriasJ++;
            }
            else if (valorJ == valorCPU)
            {
                resultado = "Empate";
                LblResultado.Text = resultado;
            }
            else
            {
                resultado = "perdiste";
                LblResultado.Text = resultado;
                victoriasCPU++;
            }

        }

        private void LblPuntosJugador_Click(object sender, EventArgs e)
        {

        }
    }
}
