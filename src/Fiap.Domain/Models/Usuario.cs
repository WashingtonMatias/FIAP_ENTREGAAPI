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

        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
