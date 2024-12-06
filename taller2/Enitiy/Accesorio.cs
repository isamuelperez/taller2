using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller2.Enitiy
{
    class Accesorio : ProductoBasico
    {
        public Diseñador ? Diseñador { get; set; }
        public DateTime FechaElaboracion { get; set; }
        public Material ? Material { get; set; }

        public override Producto Clonar()
        {
            return (Producto)this.MemberwiseClone();
        }

        public override ProductoBasico Crear()
        {
            return new Accesorio();
        }
    }
}
