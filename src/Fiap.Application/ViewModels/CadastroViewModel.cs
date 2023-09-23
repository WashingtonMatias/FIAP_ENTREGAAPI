using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Application.ViewModels
{
    public class CadastroViewModel
    {
        public int Id_Cadastro { get; set; }
        public TimeSpan DataCadastro { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public TimeSpan DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
