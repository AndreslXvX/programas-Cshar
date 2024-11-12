using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_asociados
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private int celular;
        private int numero;
           
        public Cliente(string n, string a, int c, int nu)
        {
            nombre = n;
            apellido = a;
            celular = c;
            numero = nu;
        }
        public void setNombre(string i)
        {
            nombre = i;
        }
        public void setApellido(string i)
        {
            apellido = i;
        }
        public void setCelular(int i)
        {
            celular = i;
        }
        public void setNumero(int i)
        {
            numero = i;
        }
        public string getNombres()
        {
            return nombre + " " + apellido;
        }
        
        public int getNumero()
        {
            return numero;
        }
        public int getCelular()
        {
            return celular;
        }
    }   

}
