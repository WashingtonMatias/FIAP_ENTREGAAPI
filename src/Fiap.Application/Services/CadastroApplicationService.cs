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
        private readonly ICadastroService _cadastroService;

        public CadastroApplicationService(ICadastroService CadastrosService)
        {
            _cadastroService = CadastrosService;
        }

        public void AdicionarCadastro(CadastroViewModel CadastrosViewModel)
        {
            Cadastro Cadastros = MontarObjetoCadastros(CadastrosViewModel);

            _cadastroService.AdicionarCadastro(Cadastros);
        }

        private static Cadastro MontarObjetoCadastros(CadastroViewModel CadastrosViewModel)
        {
            return new Cadastro(CadastrosViewModel.Id_Cadastro,
                                                  CadastrosViewModel.DataCadastro,
                                                  CadastrosViewModel.Nome,
                                                  CadastrosViewModel.SobreNome,
                                                  CadastrosViewModel.DataNascimento,
                                                  CadastrosViewModel.Cpf,
                                                  CadastrosViewModel.Email);
        }

        public void AtualizarCadastro(CadastroViewModel CadastrosViewModel)
        {
            Cadastro Cadastros = MontarObjetoCadastros(CadastrosViewModel);

            _cadastroService.AtualizarCadastro(Cadastros);
        }

        public void DeletarCadastro(Guid id)
        {
            _cadastroService.DeletarCadastro(id);
        }

        public CadastroViewModel ObterCadastro(Guid id)
        {
            return mapperCadastro(_cadastroService.ObterCadastro(id));
        }

        public IEnumerable<CadastroViewModel> ObterCadastros()
        {
            var cadastros = _cadastroService.ObterCadastros();
            var cadastroViewModel = new List<CadastroViewModel>();
            foreach (var cadastro in cadastros)
            {
                cadastroViewModel.Add(mapperCadastro(cadastro));
            }
            return cadastroViewModel;
        }

        private static CadastroViewModel mapperCadastro(Cadastro cadastro)
        {
            return new CadastroViewModel
            {
                Id_Cadastro = cadastro.Id_Cadastro,
                Nome = cadastro.Nome,
                Cpf = cadastro.Cpf,
                SobreNome = cadastro.SobreNome,
                DataCadastro = cadastro.DataCadastro,
                DataNascimento = cadastro.DataNascimento,
                Email = cadastro.Email
            };
        }

        public IEnumerable<Tbl_EstabelecimentoViewModel> ObterEstabeleciemento()
        {
            var estabelecimentos = _cadastroService.ObterEstabelecimento();
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
