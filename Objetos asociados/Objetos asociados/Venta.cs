using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_asociados
{
    internal class Venta
    {
        private int numero;
        private int monto;
        private Cliente cliente;
        private Fecha fecha;

        public Venta(int nu, int m, Cliente c, Fecha f)
        {
            numero = nu;
            monto = m;
            cliente = c;
            fecha = f;
        }
        public void setNumero(int i)
        {
            numero = i;
        }
        public void setMonto(int i)
        {
            monto = i;
        }
        public void setCliente(Cliente i)
        {
            cliente = i;
        }
        public void getFecha(Fecha i)
        {
            fecha = i;
        }
        public int getNumero()
        {
            return numero;
        }
        public int getMonto()
        {
            return monto;
        }
        public Cliente getCliente()
        {
            return cliente;
        }
        public Fecha getFecha()
        {
            return fecha;
        }
    }
}
