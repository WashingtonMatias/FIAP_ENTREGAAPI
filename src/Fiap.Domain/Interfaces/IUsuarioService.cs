using Fiap.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Domain.Interfaces
{
    public interface IUsuarioService
    {
        void AdicionarUsuario(Usuario usuario);
        void AtualizarUsuario(Usuario usuario);
        void DeletarUsuario(Guid id);
        Usuario ObterUsuario(Guid id);
        IEnumerable<Usuario> ObterUsuarios();
    }
}
