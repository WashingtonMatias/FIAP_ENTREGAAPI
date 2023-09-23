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
    public class CadastroRepository : ICadastroRepository
    {
        private FiapContext _dbContext;

        public CadastroRepository(FiapContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AdicionarUsuario(Cadastro Usuario)
        {
            _dbContext.Cadastro.Add(Usuario);
            _dbContext.SaveChanges();
        }

        public void AtualizarUsuario(Cadastro Usuario)
        {
            _dbContext.Cadastro.Update(Usuario);
            _dbContext.SaveChanges();
        }

        public void DeletarUsuario(int id)
        {
            var Usuario = _dbContext.Cadastro.FirstOrDefault(u => u.Id_Cadastro == id);
            if (Usuario != null)
            _dbContext.Cadastro.Remove(Usuario);
           
            _dbContext.SaveChanges();
        }

        public IEnumerable<Tbl_Estabelecimento> ObterEstabelecimento()
        {
            return _dbContext.Tbl_Estabelecimento.ToList();
        }

        public Cadastro ObterUsuario(int id)
        {
            return _dbContext.Cadastro.FirstOrDefault(u => u.Id_Cadastro == id);
        }

        public IEnumerable<Cadastro> ObterUsuarios()
        {
            return _dbContext.Cadastro.ToList();
        }
    }
}
