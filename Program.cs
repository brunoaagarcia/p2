namespace p2BRUNO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ILogger logger = new ConsoleLogger();

            
            var cliente1 = new Cliente("SERJINHO", "SERJAO@email.com", "123.456.789-00");
            var cliente2 = new Cliente("ANTONIO", "toninho@email.com", "987.654.321-00");

            
            var produto1 = new Produto("Motor 5.5L", 5000.00m, "Mecânica");
            var produto2 = new Produto("Roda de Liga Leve", 800.00m, "Estética");
            var produto3 = new Produto("Capo de carbono", 7000.00m, "Estrutura");

            var itensPedido1 = new List<ItemPedido>
            {
                new ItemPedido(produto1, 1),
                new ItemPedido(produto2, 3)
            };

            var pedidoFactory = new PedidoFactory();
            var pedido1 = pedidoFactory.CriarPedido(cliente1, itensPedido1);

            var itensPedido2 = new List<ItemPedido>
            {
                new ItemPedido(produto3, 5),
                new ItemPedido(produto2, 1)
            };

            var pedido2 = pedidoFactory.CriarPedido(cliente2, itensPedido2);

            var regrasDesconto = new List<IDescontoStrategy>
            {
                new DescontoPorCategoria("Mecânica", 0.10m),
                new DescontoPorQuantidade(3, 0.05m)
            };

            var aplicador = new AplicacaoDeDescontos(regrasDesconto, logger);
            aplicador.AplicarDescontos(pedido1);
            aplicador.AplicarDescontos(pedido2);

            var relatorio = new RelatorioDePedidos();
            relatorio.Gerar(new List<Pedido> { pedido1, pedido2 });
        }
    }
}

