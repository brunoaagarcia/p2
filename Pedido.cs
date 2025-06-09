using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p2BRUNO;

namespace p2BRUNO
{
    public class Pedido
    {
        public Guid Id { get; }
        public Cliente Cliente { get; }
        public List<ItemPedido> Itens { get; }
        public DateTime Data { get; }
        public decimal ValorTotal => Itens.Sum(item => item.Subtotal);

        public Pedido(Cliente cliente, List<ItemPedido> itens)
        {
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente));
            if (itens == null || !itens.Any())
                throw new ArgumentException("O pedido deve conter pelo menos um item.");

            Id = Guid.NewGuid();
            Cliente = cliente;
            Itens = itens;
            Data = DateTime.Now;



        }
    }
}
