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
        
    } 
}
