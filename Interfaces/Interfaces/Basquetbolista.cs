using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Basquetbolista : Deportista, IBasquetbolista
    {
        private bool estatura = true;
        public Basquetbolista(string n, string p, int e, double es, bool esttra) : base(n, p, e, es) { }

        public void comprobarEstatura()
        {
             estatura = true;

            if ( Alto > 1.90 )
            {
                estatura = true;
            }
            else
            {
                estatura = false;
            }
        }

    }
}
