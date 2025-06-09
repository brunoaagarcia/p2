using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2BRUNO
{
    public class RelatorioClientes
    {
        public void Gerar(List<Pedido> pedidos)
        {
            Console.WriteLine("=== RELATÓRIO DE PEDIDOS ===\n");

            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"Pedido ID: {pedido.Id}");
                Console.WriteLine($"Data: {pedido.Data.ToShortDateString()}");
                Console.WriteLine($"Cliente: {pedido.Cliente.Nome}");
                Console.WriteLine("Itens:");

                foreach (var item in pedido.Itens)
                {
                    Console.WriteLine($"- Produto: {item.Produto.Nome}");
                    Console.WriteLine($"  Quantidade: {item.Quantidade}");
                    Console.WriteLine($"  Preço Unitário: R$ {item.Produto.Preco:F2}");
                    Console.WriteLine($"  Subtotal: R$ {item.Subtotal:F2}");
                }

                Console.WriteLine($"Valor Total: R$ {pedido.ValorTotal:F2}");
                Console.WriteLine(new string('-', 40));
            }
        }

    }
}
