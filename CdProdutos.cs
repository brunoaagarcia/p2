using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2BRUNO
{
    class CdProdutos
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public string Categoria { get; private set; }

    
      public CdProdutos(string nome, decimal preco, string categoria)
      {
            Id = Guid.NewGuid();
            Nome = nome;
            Preco = preco;
            Categoria = categoria;

            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Preencha o campo(Produto).");
            if (preco <= 0)
                throw new ArgumentException("Preço deve ser maior que zero.");
            if (string.IsNullOrWhiteSpace(categoria))
                throw new ArgumentException("Preencha o Campo(Categoria).");


        }


    }

}
