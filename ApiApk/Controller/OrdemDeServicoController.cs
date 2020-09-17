using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiApk.Controller
{
    public class OrdemDeServicoController: ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public OrdemDeServicoDTO Obter(int idOrdemDeServico)
        {
            return new OrdemDeServicoDTO();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria()
        {
            return true;
        }

        [HttpPut]
        [ActionName("atualiza")]
        public OrdemDeServicoDTO Atualiza()
        {
            return new OrdemDeServicoDTO();
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove()
        {
            return true;
        }
    }
}
