using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Herencia
{
    internal class Clientes : Personas
    {
        private int puntos;

        public Clientes(string n, string a, string c, string e, string cel, int p) : base(n, a, c, e, cel)
        {
                puntos = p;
        }
        public int Puntos
        {
            get
            {
                return puntos;
            }
            set
            {
                puntos = value;
            }
        }
        public override void darDescripcion()
        {
            MessageBox.Show("Nombre: " + Nombre.ToString() + " Apellido: " + Apellido.ToString() + " Edad: " 
                + Edad.ToString() + " Celular: " + Celular.ToString() + " Calle: " + Calle.ToString() + " Puntos: "
                + Puntos.ToString() );
        }
    }
    public enum TipoCliente {normal = 100, VIP = 500 }
}
