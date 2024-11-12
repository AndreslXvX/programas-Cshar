using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_enumerados
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private string numero;
        private string celular;
        private dynamic tipo;

        public Cliente(string n, string a, string num, string cel, tipoDeCliente t)
        {
            nombre = n;
            apellido = a;
            numero = num;
            celular = cel;
            tipo = t;
        }
        public string NOMBRE
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
        public string APELLIDO
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
        public string CELULAR
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
        public dynamic TIPO
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }
        public string DATOS
        {
            get
            {
                string datos =
                    "Nombre: " + NOMBRE.ToString() + " " + APELLIDO.ToString() +
                    " Numero celular: " + CELULAR.ToString() +
                    " Tipo de Cliente: " + TIPO.ToString() + " " + (int)TIPO;

                return datos.ToString();
            }
        }
        public enum tipoDeCliente {normal = 100,premium = 200}

        
    }
}
