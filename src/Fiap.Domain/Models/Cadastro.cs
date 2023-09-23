using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Domain.Models
{
    [Table("CADASTRO")]
    public class Cadastro
    {
        public Cadastro(int id_Cadastro, TimeSpan dataCadastro, string nome, string sobreNome, TimeSpan dataNascimento, string cpf, string email)
        {
            Id_Cadastro = id_Cadastro;
            DataCadastro = dataCadastro;
            Nome = nome;
            SobreNome = sobreNome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Email = email;
        }

        [Column("ID_CADASTRO")]
        [Display(Name = "Id_Cadastro")]
        public int Id_Cadastro { get; set; }

        [Column("DATACADASTRO")]
        [Display(Name = "DataCadastro")]
        public TimeSpan DataCadastro { get; set; }

        [Column("NOME")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("SOBRENOME")]
        [Display(Name = "SobreNome")]
        public string SobreNome { get; set; }

        [Column("DATANASCIMENTO")]
        [Display(Name = "DataNascimento")]
        public TimeSpan DataNascimento { get; set; }

        [Column("CPF")]
        [Display(Name = "Cpf")]
        public string Cpf { get; set; }

        [Column("EMAIL")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
