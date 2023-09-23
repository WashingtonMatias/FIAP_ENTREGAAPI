using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Application.ViewModels
{
    public class CadastroViewModel
    {
        public Guid Id_Cadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
