using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2BRUNO
{
    public class AplicacaoDeDescontos
    {
        private readonly IEnumerable<IDescontoStrategy> _estrategias;
        private readonly ILogger _logger;

        public AplicacaoDeDescontos(IEnumerable<IDescontoStrategy> estrategias, ILogger logger)
        {
            _estrategias = estrategias ?? throw new ArgumentNullException(nameof(estrategias));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void AplicarDescontos(Pedido pedido)
        {
            foreach (var estrategia in _estrategias)
            {
                var desconto = estrategia.CalcularDesconto(pedido);
                if (desconto > 0)
                {
                    _logger.Log($"Desconto aplicado: R$ {desconto:F2} ({estrategia.GetType().Name})");
                }
            }
        }
    }
}
