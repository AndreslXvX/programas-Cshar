using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Deportista
    {
        private string nombres;
        private string posicion;
        private int edad;
        private double alto;

        public Deportista(string n, string p, int e, double es)
        {
            nombres = n;
            posicion = p;
            edad = e;
            alto = es;
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }
            set
            {
                nombres = value;
            }
        }
        public string Posicion
        {
            get
            {
                return posicion;
            }
            set
            {
                posicion = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        public double Alto
        {
            get
            {
                return alto;
            }
            set
            {
                alto = value;

            }
        }
    }
}
