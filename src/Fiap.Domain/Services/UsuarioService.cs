using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            _usuarioRepository.AdicionarUsuario(usuario);
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            _usuarioRepository.AtualizarUsuario(usuario);
        }

        public void DeletarUsuario(Guid id)
        {
            _usuarioRepository.DeletarUsuario(id);
        }

        public Usuario ObterUsuario(Guid id)
        {
           return _usuarioRepository.ObterUsuario(id);
        }

        public IEnumerable<Usuario> ObterUsuarios()
        {
            return _usuarioRepository.ObterUsuarios();
        }
    }
}
