using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace taller2.Enitiy
{
    class Ropa : ProductoBasico
    {
        public string ? Color { get; set; }
        public Tela ? Tela { get; set; }
        public string ? Talla { get; set; }
        public Marca ? Marca { get; set; }

        public override Producto Clonar()
        {
            return (Producto)this.MemberwiseClone();
        }

        public override ProductoBasico Crear()
        {
            return new Ropa();
        }
    }
}
