using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller2.Enitiy
{
    class Calzado : ProductoBasico
    {
        public string ? Capellada  { get; set; }
        public string ? Suela { get; set; }
        public string ? Cierre { get; set; }

        public override Producto Clonar()
        {
            return (Producto)this.MemberwiseClone();
        }

        public override ProductoBasico Crear()
        {
            return new Calzado();
        }
    }
}
