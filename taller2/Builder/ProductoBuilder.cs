using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller2.Enitiy;

namespace taller2.Builder
{
    class ProductoBuilder
    {
        private ProductoBasico _producto;

        public ProductoBuilder(ProductoBasico producto)
        {
            _producto = producto;
        }

        public ProductoBuilder SetColor(string color)
        {
            if (_producto is Ropa ropa)
            {
                ropa.Color = color;
            }
            return this;
        }

        public ProductoBuilder SetMaterial(string material)
        {
            if (_producto is Calzado calzado)
            {
                calzado.Capellada = material;
            }
            return this;
        }

        public ProductoBuilder SetTalla(string talla)
        {
            if (_producto is Ropa ropa)
            {
                ropa.Talla = talla;
            }
            return this;
        }

        public ProductoBasico Construir()
        {
            return _producto;
        }
    }
}
