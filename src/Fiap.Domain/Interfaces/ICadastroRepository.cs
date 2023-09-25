﻿using Fiap.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Domain.Interfaces
{
    public interface ICadastroRepository
    {
        Cadastro AdicionarCadastro(Cadastro cadastro);
        Cadastro AtualizarCadastro(Cadastro cadastro);
        void DeletarCadastro(Guid id);
        Cadastro ObterCadastro(Guid id);
        IEnumerable<Cadastro> ObterCadastros();
        IEnumerable<Tbl_Estabelecimento> ObterEstabelecimento();
    }
}
