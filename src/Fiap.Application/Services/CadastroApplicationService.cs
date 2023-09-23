using Fiap.Application.Interfaces;
using Fiap.Application.ViewModels;
using Fiap.Data.Context;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Application.Services
{
    public class CadastroApplicationService : ICadastroApplicaionService
    {
        private readonly ICadastroService _UsuarioService;

        public CadastroApplicationService(ICadastroService UsuarioService)
        {
            _UsuarioService = UsuarioService;
        }

        public void AdicionarUsuario(CadastroViewModel UsuarioViewModel)
        {
            Cadastro Usuario = MontarObjetoUsuario(UsuarioViewModel);

            _UsuarioService.AdicionarUsuario(Usuario);
        }

        private static Cadastro MontarObjetoUsuario(CadastroViewModel UsuarioViewModel)
        {
            return new Cadastro(UsuarioViewModel.Id_Cadastro,
                                                  UsuarioViewModel.DataCadastro,
                                                  UsuarioViewModel.Nome,
                                                  UsuarioViewModel.SobreNome,
                                                  UsuarioViewModel.DataNascimento,
                                                  UsuarioViewModel.Cpf,
                                                  UsuarioViewModel.Email);
        }

        public void AtualizarUsuario(CadastroViewModel UsuarioViewModel)
        {
            Cadastro Usuario = MontarObjetoUsuario(UsuarioViewModel);

            _UsuarioService.AtualizarUsuario(Usuario);
        }

        public void DeletarUsuario(Guid id)
        {
            throw new NotImplementedException();
        }

        public CadastroViewModel ObterUsuario(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CadastroViewModel> ObterUsuarios()
        {
            var cadastros = _UsuarioService.ObterUsuarios();
            var cadastroViewModel = new List<CadastroViewModel>();
            foreach (var cadastro in cadastros)
            {
                cadastroViewModel.Add(new CadastroViewModel
                {
                    Id_Cadastro = cadastro.Id_Cadastro,
                    Nome = cadastro.Nome,
                    Cpf = cadastro.Cpf,
                    SobreNome = cadastro.SobreNome,
                    DataCadastro = cadastro.DataCadastro,
                    DataNascimento = cadastro.DataNascimento,
                    Email = cadastro.Email
                });
            }
            return cadastroViewModel;
        }

        public IEnumerable<Tbl_EstabelecimentoViewModel> ObterEstabeleciemento()
        {
            var estabelecimentos = _UsuarioService.ObterEstabelecimento();
            var estabelecimentoViewModel = new List<Tbl_EstabelecimentoViewModel>();
            foreach (var estabelecimento in estabelecimentos)
            {
                estabelecimentoViewModel.Add(new Tbl_EstabelecimentoViewModel
                {
                    ID_ESTABELECIMENTO = estabelecimento.ID_ESTABELECIMENTO,
                    DH_CRIACAO = estabelecimento.DH_CRIACAO,
                    NOME_ESTABELECIMENTO = estabelecimento.NOME_ESTABELECIMENTO
                });
            }

            return estabelecimentoViewModel;
        }
    }
}
