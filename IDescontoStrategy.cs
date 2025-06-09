using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2BRUNO
{
    public interface IDescontoStrategy
    {
        decimal CalcularDesconto(ItemPedido item);
    }
}
