using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2BRUNO
{
    public class ItemPedido
    {

        public Produto Produto { get; }
        public int Quantidade { get; }
        public decimal Subtotal => Produto.Preco * Quantidade;

        public ItemPedido(Produto produto, int quantidade)
        {
            if (quantidade <= 0)
                throw new ArgumentException("A quantidade deve ser maior que zero.");

            Produto = produto;
            Quantidade = quantidade;
        }

    }
}
