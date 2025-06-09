using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2BRUNO
{
    public class DescontoPorCategoria : IDescontoStrategy
    {
        private readonly string _categoriaAlvo;
        private readonly decimal _percentual;

        public DescontoPorCategoria(string categoriaAlvo, decimal percentual)
        {
            _categoriaAlvo = categoriaAlvo;
            _percentual = percentual;
        }

        public decimal CalcularDesconto(Pedido pedido)
        {
            return pedido.Itens
                         .Where(item => item.Produto.Categoria == _categoriaAlvo)
                         .Sum(item => item.Subtotal * _percentual);
        }
    }
}
