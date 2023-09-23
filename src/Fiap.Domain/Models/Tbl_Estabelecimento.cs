using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Domain.Models
{
    [Table("TBL_ESTABELECIMENTO")]
    public class Tbl_Estabelecimento
    {
        public int ID_ESTABELECIMENTO { get; set; }
        public DateTime DH_CRIACAO { get; set; }
        public string NOME_ESTABELECIMENTO { get; set; }
    }
}
