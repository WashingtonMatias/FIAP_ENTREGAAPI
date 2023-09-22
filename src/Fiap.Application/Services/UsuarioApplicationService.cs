using Fiap.Application.Interfaces;
using Fiap.Application.ViewModels;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;

namespace Fiap.Application.Services
{
    public class UsuarioApplicationService : IUsuarioApplicaionService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioApplicationService(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public void AdicionarUsuario(UsuarioViewModel usuarioViewModel)
        {
            Usuario usuario = MontarObjetoUsuario(usuarioViewModel);

            _usuarioService.AdicionarUsuario(usuario);
        }

        private static Usuario MontarObjetoUsuario(UsuarioViewModel usuarioViewModel)
        {
            return new Usuario(usuarioViewModel.Id,
                                                  usuarioViewModel.DataCadastro,
                                                  usuarioViewModel.Nome,
                                                  usuarioViewModel.SobreNome,
                                                  usuarioViewModel.DataCadastro,
                                                  usuarioViewModel.Cpf,
                                                  usuarioViewModel.Email);
        }

        public void AtualizarUsuario(UsuarioViewModel usuarioViewModel)
        {
            Usuario usuario = MontarObjetoUsuario(usuarioViewModel);

            _usuarioService.AtualizarUsuario(usuario);
        }

        public void DeletarUsuario(Guid id)
        {
            throw new NotImplementedException();
        }

        public UsuarioViewModel ObterUsuario(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioViewModel> ObterUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
