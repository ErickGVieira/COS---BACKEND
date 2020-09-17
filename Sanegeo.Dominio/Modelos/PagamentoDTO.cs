using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Modelos
{
    public class PagamentoDTO
    {
        public int id { get; set; }
        public decimal valor { get; set; }
        public int idOrdemServico { get; set; }
        public int idTipoPagamento { get; set; }

        public OrdemDeServicoDTO OrdemDeServico { get; set; }
        public TipoPagamentoDTO TipoPagamento { get; set; }
    }
}
