using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2BRUNO
{
    public class DescontoPorQuantidade : IDescontoStrategy
    {
        private readonly int _quantidadeMinima;
        private readonly decimal _percentual;

        public DescontoPorQuantidade(int quantidadeMinima, decimal percentual)
        {
            _quantidadeMinima = quantidadeMinima;
            _percentual = percentual;
        }

        public decimal CalcularDesconto(ItemPedido item)
        {

            return 0;
        }
    }
}
