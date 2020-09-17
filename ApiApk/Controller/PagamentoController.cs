using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiApk.Controller
{
    public class PagamentoController: ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public PagamentoDTO Obter(int idOrdemDeServico)
        {
            return new PagamentoDTO();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria()
        {
            return true;
        }

        [HttpPut]
        [ActionName("atualiza")]
        public PagamentoDTO Atualiza()
        {
            return new PagamentoDTO();
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove()
        {
            return true;
        }
    }
}
