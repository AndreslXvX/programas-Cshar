using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piedra_papel_tijera
{
    internal class Combates
    {
        
        int rondas = 0;
        string resultado = "";

        public string RESULTADO 
        { 
            get 
            { 
                return resultado; 
            } 
        }
        public string RONDAS
        {
            get
            {
                return rondas.ToString();
            }
            set
            {
                rondas = int.Parse(value);
            }
        }

        public void Combate(Jugadores JJ, Jugadores JCPU)
        {

            if (JJ.JUGADA == "piedra" && JCPU.JUGADA == "tijera" ||
                JJ.JUGADA == "papel" && JCPU.JUGADA == "piedra" ||
                JJ.JUGADA == "tijera" && JCPU.JUGADA == "papel")
            {
                resultado = "Ganador: Jugador";
                rondas++;
                JJ.VICTORIAS++;
            }
            else if (JJ.JUGADA == JCPU.JUGADA) 
            { 
                resultado = "Empate";
                rondas++;
            }
            else 
            { 
                resultado = "Ganador: CPU";
                rondas++;
                JCPU.VICTORIAS++;
            }
            
        }
        
    }
}
