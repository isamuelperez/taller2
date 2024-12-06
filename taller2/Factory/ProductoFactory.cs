using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller2.Enitiy;

namespace taller2.Factory
{
    class ProductoFactory
    {
        public static ProductoBasico CrearProducto(string tipo)
        {
            return tipo switch
            {
                "Ropa" => new Ropa(),
                "Accesorio" => new Accesorio(),
                "Calzado" => new Calzado(),
                _ => throw new ArgumentException("Tipo de producto desconocido")
            };
        }
    }
}
