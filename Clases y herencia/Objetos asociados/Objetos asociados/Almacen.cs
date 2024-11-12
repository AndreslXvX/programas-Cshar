using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_asociados
{
    internal class Almacen
    {
        private Venta[] ventas;

        public Almacen()
        {
            ventas = new Venta[100];
        }
        public void añadirVenta(int mo, Cliente cte, Fecha fe)
        {
            bool resultado = false;
            for (int i = 0; i < ventas.Length; i++)
            {
                if (ventas[i] == null)
                {
                    ventas[i] = new Venta(i + 1, mo, cte, fe);
                    resultado = true;
                    break;
                }

            }
            if (resultado == false)
            {
                MessageBox.Show("Hubo un error....nose en donde, hechale ganas....xd");
            }
        }
        public Venta ConsultarUltimaVenta()
        {
            bool resultado = false;
            Venta venta = null;

            if (ventas[0] != null)
            {
                for (int i = 1; i < ventas.Length; i++)
                {

                    if (ventas[i] == null)
                    {
                        venta = ventas[i - 1];
                        resultado = true;
                        break;
                    }
                }
            }
            if (resultado == false)
            {
                MessageBox.Show("valio madres");
            }
            return venta;
        }
        public Venta ConsultarVenta(int n)
        {
            Venta venta = null;
            for (int i = 0; i < n; i++)
            {
                if (ventas[i] != null)
                {
                    if (n == ventas[i].getNumero())
                    {
                        venta = ventas[i];
                    }
                }
                else
                {
                    break;
                }
            }
            return venta;
        }
    }
}
