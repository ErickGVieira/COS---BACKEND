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
    }
}
