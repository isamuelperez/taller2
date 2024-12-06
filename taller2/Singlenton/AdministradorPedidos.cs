using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller2.Enitiy;
using taller2.Models;

namespace taller2.Singlenton
{
    class AdministradorPedidos
    {
        private static AdministradorPedidos _instancia;
        private List<Pedido> _pedidos = new List<Pedido>();
        private int _contadorId = 0;

        private AdministradorPedidos() { }

        public static AdministradorPedidos ObtenerInstancia()
        {
            return _instancia ??= new AdministradorPedidos();
        }

        public Pedido RegistrarPedido(Producto producto)
        {
            var pedido = new Pedido
            {
                Id = ++_contadorId,
                Producto = producto,
                
            };
            _pedidos.Add(pedido);
            return pedido;
        }

        public Pedido ObtenerPedido(int id)
        {
            return _pedidos.Find(p => p.Id == id);
        }
    }

}
