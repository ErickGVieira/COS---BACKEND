using Cos.Dominio.Modelos;
using Sanegeo.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiApk.Controller
{
    public class OrcamentoController: ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public OrcamentoDTO Obter(int idOrcamento)
        {
            return new ServicoOrcamento().ObtemOrcamento(idOrcamento);
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<OrcamentoDTO> ObterTodos()
        {
            return new ServicoOrcamento().ObtemOrcamentos();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria(OrcamentoDTO orcamentoDTO)
        {
            return new ServicoOrcamento().CriaOrcamento(orcamentoDTO);
        }

        [HttpPut]
        [ActionName("atualiza")]
        public OrcamentoDTO Atualiza(OrcamentoDTO orcamentoDTO)
        {
            return new ServicoOrcamento().AtualizaOrcamento(orcamentoDTO);
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove(int idOrcamento)
        {
            return new ServicoOrcamento().RemoveOrcamento(idOrcamento);
        }
    }
}
