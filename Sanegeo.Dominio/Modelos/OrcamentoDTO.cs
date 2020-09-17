using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Modelos
{
    public class OrcamentoDTO
    {
        public int id { get; set; }
        public int idOrdemServico { get; set; }
        public decimal valor { get; set; }
        public string descricao { get; set; }

        public OrdemDeServicoDTO OrdemDeServico { get; set; }
    }
}
