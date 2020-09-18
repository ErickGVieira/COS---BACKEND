using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Repositorios.SQL
{
    public interface IRepositorioOrcamento
    {
        OrcamentoDTO ObtemOrcamento(int idOrcamento);
        List<OrcamentoDTO> ObtemOrcamentos();
        bool RemoveOrcamento(int idOrcamento);
        OrcamentoDTO AtualizaOrcamento(OrcamentoDTO orcamentoDTO);
        bool CriaOrcamento(OrcamentoDTO orcamentoDTO);
    }
}
