using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Domain.Services
{
    public class CadastroService : ICadastroService
    {
        private readonly ICadastroRepository _UsuarioRepository;

        public CadastroService(ICadastroRepository UsuarioRepository)
        {
            _UsuarioRepository = UsuarioRepository;
        }

        public void AdicionarUsuario(Cadastro Usuario)
        {
            _UsuarioRepository.AdicionarUsuario(Usuario);
        }

        public void AtualizarUsuario(Cadastro Usuario)
        {
            _UsuarioRepository.AtualizarUsuario(Usuario);
        }

        public void DeletarUsuario(int id)
        {
            _UsuarioRepository.DeletarUsuario(id);
        }

        public IEnumerable<Tbl_Estabelecimento> ObterEstabelecimento()
        {
            return _UsuarioRepository.ObterEstabelecimento();
        }

        public Cadastro ObterUsuario(int id)
        {
           return _UsuarioRepository.ObterUsuario(id);
        }

        public IEnumerable<Cadastro> ObterUsuarios()
        {
            return _UsuarioRepository.ObterUsuarios();
        }
    }
}
