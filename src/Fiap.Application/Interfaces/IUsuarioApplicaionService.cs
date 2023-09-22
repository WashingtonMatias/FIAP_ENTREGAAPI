using Fiap.Application.ViewModels;

namespace Fiap.Application.Interfaces
{
    public interface IUsuarioApplicaionService
    {
        void AdicionarUsuario(UsuarioViewModel usuarioViewModel);
        void AtualizarUsuario(UsuarioViewModel usuarioViewModel);
        void DeletarUsuario(Guid id);
        UsuarioViewModel ObterUsuario(Guid id);
        IEnumerable<UsuarioViewModel> ObterUsuarios();
    }
}
