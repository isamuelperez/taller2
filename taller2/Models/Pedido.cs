using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller2.Enitiy;

namespace taller2.Models
{
    class Pedido
    {
        public int Id { get; set; }
        public string Estado { get; set; } = "En proceso";
        public Producto Producto { get; set; }
    }

}
