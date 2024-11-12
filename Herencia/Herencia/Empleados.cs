using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Empleados : Personas
    {
        private double salario;
        public Empleados(string n, string a, string c, string e, string cel, double sal) :
            base(n, a, c, e, cel)
        {
            salario = sal;
        }
        public double Salario
        {
            get
            {
                return salario;
            }
            set
            {
                salario = value;
            }
        }
        public override void darDescripcion()
        {
            MessageBox.Show("Nombre: " + Nombre + " Apellido: " + Apellido + " Edad: "
                + Edad + " Celular: " + Celular + " Calle: " + Calle + " Salario: "
                + Salario.ToString());
        }
    }
}

