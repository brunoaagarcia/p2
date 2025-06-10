using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2BRUNO
{
    public class Cliente
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }

        public Cliente(string nome, string email, string cpf)
        {
            Id= Guid.NewGuid();
            Nome = nome;
            Email = email;
            Cpf = cpf;

            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome do cliente é obrigatório.");

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                throw new ArgumentException("Email inválido.");

            if (string.IsNullOrWhiteSpace(cpf)) 
                throw new ArgumentException("CPF inválido.");


        }

    }   
}
