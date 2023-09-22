using Fiap.Data.Context;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private FiapContext _dbContext;

        public UsuarioRepository(FiapContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            _dbContext.Usuario.Add(usuario);
            _dbContext.SaveChanges();
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            _dbContext.Usuario.Update(usuario);
            _dbContext.SaveChanges();
        }

        public void DeletarUsuario(Guid id)
        {
            var usuario = _dbContext.Usuario.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            _dbContext.Usuario.Remove(usuario);
           
            _dbContext.SaveChanges();
        }

        public Usuario ObterUsuario(Guid id)
        {
            return _dbContext.Usuario.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<Usuario> ObterUsuarios()
        {
            return _dbContext.Usuario.ToList();
        }
    }
}
