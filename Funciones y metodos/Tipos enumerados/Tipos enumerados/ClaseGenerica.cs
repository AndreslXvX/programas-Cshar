using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tipos_enumerados
{
    internal class ClaseGenerica<T>
    {
        private T objeto;

        public ClaseGenerica(T obj)
        {
            objeto = obj;
        }

        public T getObjeto()
        {
            return objeto;
        }
        
    }
}
