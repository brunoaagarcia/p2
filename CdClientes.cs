using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2BRUNO
{
    class CdClientes
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }

        public CdClientes(string nome, string email, string cpf)
        {
            Id= Guid.NewGuid();
            Nome = nome;
            Email = email;
            Cpf = cpf;
       

        }


    }
}
