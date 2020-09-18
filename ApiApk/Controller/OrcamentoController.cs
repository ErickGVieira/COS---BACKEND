using Cos.Dominio.Modelos;
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
            return new OrcamentoDTO();
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<OrcamentoDTO> ObterTodos()
        {
            return new List<OrcamentoDTO>();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria()
        {
            return true;
        }

        [HttpPut]
        [ActionName("atualiza")]
        public OrcamentoDTO Atualiza()
        {
            return new OrcamentoDTO();
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove()
        {
            return true;
        }
    }
}
