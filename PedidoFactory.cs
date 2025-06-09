using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2BRUNO
{
    public class PedidoFactory
    {
        public Pedido CriarPedido(Cliente cliente, List<ItemPedido> itens)
        {
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente));
            if (itens == null || itens.Count == 0)
                throw new ArgumentException("coloque um item.");

            var pedido = new Pedido(cliente, itens);
            return pedido;
        }
    }
}
