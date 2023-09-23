using Fiap.Application.ViewModels;
using Fiap.Domain.Models;

namespace Fiap.Application.Interfaces
{
    public interface ICadastroApplicaionService
    {
        void AdicionarUsuario(CadastroViewModel UsuarioViewModel);
        void AtualizarUsuario(CadastroViewModel UsuarioViewModel);
        void DeletarUsuario(Guid id);
        CadastroViewModel ObterUsuario(Guid id);
        IEnumerable<CadastroViewModel> ObterUsuarios();

        IEnumerable<Tbl_EstabelecimentoViewModel> ObterEstabeleciemento();
    }
}
