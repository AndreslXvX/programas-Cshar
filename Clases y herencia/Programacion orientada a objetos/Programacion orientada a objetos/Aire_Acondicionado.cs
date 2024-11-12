using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_orientada_a_objetos
{
    internal class Aire_Acondicionado
    {
        private string marca;
        private string modelo;
        private string color;
        private int voltaje;
        private int btu;
        private int temperatura;

        
        public Aire_Acondicionado(string ma, string mo, string co, int vol, int bt, int temp)
        {
            marca = ma;
            modelo = mo;
            color = co;
            voltaje = vol;
            btu = bt;
            temperatura = temp;
        }

        public void setMarca(string i)
        {
            marca = i;
            
        }
        public void setModelo(string i)
        {
            modelo = i;
        }
        public void setColor(string i)
        {
            color = i;
        }
        public void setVoltaje(int i)
        {
            voltaje = i;
        }
        public void setBtu(int i)
        {
            btu = i;
        }
        public void setTemperatura(int i)
        {
            temperatura = i;
        }
        public string getMarca()
        {
            return marca;
        }
        public string getModelo()
        {
            return modelo;
        }
        public string getColor()
        {
            return color;
        }
        public int getVoltaje()
        {
            return voltaje;
        }
        public int getBtu()
        {
            return btu;
        }
        public int getTemperatura()
        {
            return temperatura;
        }


        public void SubirTemperatura()
        {
            if (temperatura < 30)
            {
                temperatura++;
            } else
            {
                temperatura = 30;
            }
        }
        public void SubirTemperatura(int grados)
        { 
            if (temperatura + grados > 30)
            {
                temperatura = 30;
            }
            else
            {
                temperatura = temperatura + grados;
            }

        }
        public void BajarTemperatura()
        {
            if (temperatura > 16)
            {
                temperatura--;
            }else
            {
                temperatura = 16;
            }
        }
        public void BajarTemperatura(int grados)
        {
            if (temperatura - grados < 16)
            {
                temperatura = 16;
            }
            else
            {
                temperatura = temperatura - grados;
            }
        }
        public string MostrarTemperatura()
        {
            string sttemperatura = temperatura.ToString();
            return sttemperatura;
        }


    }
}
