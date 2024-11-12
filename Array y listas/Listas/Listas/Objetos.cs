using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Objetos
    {
        string nombre;
        int valor;

        public Objetos(string nom, int val)
        {
            nombre = nom;
            valor = val;
        }
        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int VALOR
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
