using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piedra_papel_tijera
{
    internal class Jugadores(string J, int V)
    {
        string jugada = J; 
        int victorias = V; 

        public string JUGADA { get { return jugada; } set { jugada = value; } }
        public int VICTORIAS { get { return victorias; } set { victorias = value; } }
    }
}
