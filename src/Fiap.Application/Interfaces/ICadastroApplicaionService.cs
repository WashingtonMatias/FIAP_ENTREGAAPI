using Fiap.Application.ViewModels;
using Fiap.Domain.Models;

namespace Fiap.Application.Interfaces
{
    public interface ICadastroApplicaionService
    {
        void AdicionarCadastro(CadastroViewModel cadastroViewModel);
        void AtualizarCadastro(CadastroViewModel cadastroViewModel);
        void DeletarCadastro(Guid id);
        CadastroViewModel ObterCadastro(Guid id);
        IEnumerable<CadastroViewModel> ObterCadastros();

        IEnumerable<Tbl_EstabelecimentoViewModel> ObterEstabeleciemento();
    }
}
