using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Domain.Models
{
    public class Usuario
    {
        public Usuario(Guid id, DateTime dataCadastro, string nome, string sobreNome, DateTime dataNascimento, string cpf, string email)
        {
            Id = id;
            DataCadastro = dataCadastro;
            Nome = nome;
            SobreNome = sobreNome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Email = email;
        }

        public Guid Id { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Nome { get; private set; }
        public string SobreNome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
    }
}
