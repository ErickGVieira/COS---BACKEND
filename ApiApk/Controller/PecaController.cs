using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiApk.Controller
{
    public class PecaController: ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public PecaDTO Obter(int idOrdemDeServico)
        {
            return new PecaDTO();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria()
        {
            return true;
        }

        [HttpPut]
        [ActionName("atualiza")]
        public PecaDTO Atualiza()
        {
            return new PecaDTO();
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove()
        {
            return true;
        }
    }
}
