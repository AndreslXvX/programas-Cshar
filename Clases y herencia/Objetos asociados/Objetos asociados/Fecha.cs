using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_asociados
{
    internal class Fecha
    {
        private int dia;
        private int mes;
        private int año;
        private int hora;
        private int minuto;
        private int segundo;

        public Fecha(int d, int m, int a, int h, int min, int s)
        {
            dia = d;
            mes = m;
            año = a;
            hora = h;
            minuto = min;
            segundo = s;
        }
        public void setDia(int i)
        {
            dia = i;
        }
        public void setMes(int i)
        {
            mes = i;
        }
        public void setAño(int i)
        {
            año = i;
        }
        public void setHora(int i)
        {
            hora = i;
        }
        public void setMinuto(int i)
        {
            minuto = i;
        }
        public void setSegundo(int i)
        {
            segundo = i;
        }

        public int getDia()
        {
            return dia;
        }
        public int getMes()
        {
            return mes;
        }
        public int getAño()
        {
            return año;
        }
        public int getHora()
        {
            return hora;
        }
        public int getMinuto()
        {
            return minuto;
        }
        public int getSegundo()
        {
            return segundo;
        }
        public string getFecha()
        {
            string fch = dia.ToString() + "/" + mes.ToString() + "/" +
                año.ToString() + " hora: " + hora.ToString() + ":" + 
                minuto.ToString() + ":" + segundo.ToString();
            return fch;
        }
    }
}
