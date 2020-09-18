using Cos.Dominio.Modelos;
using Cos.Dominio.Repositorios.SQL;
using Sanegeo.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanegeo.Servicos
{
    public class ServicoOrcamento
    {
        private IRepositorioOrcamento repositorioOrcamento;

        public ServicoOrcamento()
        {
            this.repositorioOrcamento = new RepositorioOrcamento();
        }

        public OrcamentoDTO ObtemOrcamento(int idOrcamento)
        {
            try
            {
                return repositorioOrcamento.ObtemOrcamento(idOrcamento);
            }
            catch (Exception ex)
            {
                return new OrcamentoDTO();
            }
        }

        public List<OrcamentoDTO> ObtemOrcamentos()
        {
            try
            {
                return repositorioOrcamento.ObtemOrcamentos();
            }
            catch (Exception ex)
            {
                return new List<OrcamentoDTO>();
            }
        }

        public bool CriaOrcamento(OrcamentoDTO orcamentoDTO)
        {
            try
            {
                return repositorioOrcamento.CriaOrcamento(orcamentoDTO);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public OrcamentoDTO AtualizaOrcamento(OrcamentoDTO orcamentoDTO)
        {
            try
            {
                return repositorioOrcamento.AtualizaOrcamento(orcamentoDTO);
            }
            catch (Exception ex)
            {
                return new OrcamentoDTO();
            }
        }

        public bool RemoveOrcamento(int idOrcamento)
        {
            try
            {
                return repositorioOrcamento.RemoveOrcamento(idOrcamento);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
