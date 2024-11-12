using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instancias_y_metodos_STATIC
{
    internal class Matematica
    {
        public static int potencia(int b, int e)
        {
            int resultado = 1;

            for (int i = 0; i < e; i++)
            {
                resultado = resultado * b;
            }

            return resultado;
        }
    }
}
