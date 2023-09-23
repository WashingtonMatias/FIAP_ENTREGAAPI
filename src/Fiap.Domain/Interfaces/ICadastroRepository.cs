using Fiap.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Domain.Interfaces
{
    public interface ICadastroRepository
    {
        void AdicionarUsuario(Cadastro Usuario);
        void AtualizarUsuario(Cadastro Usuario);
        void DeletarUsuario(int id);
        Cadastro ObterUsuario(int id);
        IEnumerable<Cadastro> ObterUsuarios();
        IEnumerable<Tbl_Estabelecimento> ObterEstabelecimento();
    }
}
