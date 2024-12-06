using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller2.Enitiy
{
    public abstract class Producto
    {
        public int Id { get; set; }
        public string ? Nombre { get; set; }

        public abstract Producto Clonar();

    }
}
