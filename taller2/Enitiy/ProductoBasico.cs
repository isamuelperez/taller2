using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller2.Enitiy
{
    abstract class ProductoBasico : Producto
    {
        public abstract ProductoBasico Crear();
    }
}
