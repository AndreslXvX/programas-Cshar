namespace CONDICION_SWITCH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btProcesar_Click(object sender, EventArgs e)
        {
            int opcion = int.Parse(cmbOpciones.Text.ToString());

            switch (opcion)
            {
                case 1:
                    {
                        txtMes.Text = "ENERO";
                        break;
                    }
                case 2:
                    {
                        txtMes.Text = "FEBRERO";
                        break;
                    }
                case 3:
                    {
                        txtMes.Text = "MARZO";
                        break;
                    }
                case 4:
                    {
                        txtMes.Text = "ABRIL";
                        break;
                    }
                case 5:
                    {
                        txtMes.Text = "MAYO";
                        break;
                    }
                case 6:
                    {
                        txtMes.Text = "JUNIO";
                        break;
                    }
                case 7:
                    {
                        txtMes.Text = "JULIO";
                        break;
                    }
                case 8:
                    {
                        txtMes.Text = "AGOSTO";
                        break;
                    }
                case 9:
                    {
                        txtMes.Text = "SEPTIEMBRE";
                        break;
                    }
                case 10:
                    {
                        txtMes.Text = "OCTUBRE";
                        break;
                    }
                case 11:
                    {
                        txtMes.Text = "NOVIEMBRE";
                        break;
                    }
                case 12:
                    {
                        txtMes.Text = "DICIEMBRE";
                        break;
                    }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMes.Enabled = false;
        }
    }
}
