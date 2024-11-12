using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    abstract class Personas
    {
        private string nombre;
        private string apellido;
        private string calle;
        private string edad;
        private string celular;

        public Personas(string n, string a, string c, string e, string cel)
        {
            nombre = n;
            apellido = a;
            calle = c;
            edad = e;
            celular = cel;
        }
        public string Nombre 
        { 
            get 
            { 
                return nombre; 
            }
            set 
            { 
                nombre = value; 
            } 
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public string Calle
        {
            get
            {
                return calle;
            }
            set
            {
                calle = value;
            }
        }
        public string Celular
        {
            get
            {
                return celular;
            }
            set
            {
                celular = value;
            }
        }
        public string Edad
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
        public virtual void darDescripcion()
        {
        }
    }
}
