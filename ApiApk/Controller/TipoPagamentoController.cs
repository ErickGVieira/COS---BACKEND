using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiApk.Controller
{
    public class TipoPagamentoController: ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public TipoPagamentoDTO Obter(int idOrdemDeServico)
        {
            return new TipoPagamentoDTO();
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<TipoPagamentoDTO> ObterTodos()
        {
            return new List<TipoPagamentoDTO>();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria()
        {
            return true;
        }

        [HttpPut]
        [ActionName("atualiza")]
        public TipoPagamentoDTO Atualiza()
        {
            return new TipoPagamentoDTO();
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove()
        {
            return true;
        }
    }
}
