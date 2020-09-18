using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiApk.Controller
{
    public class StatusController: ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public StatusDTO Obter(int idStatus)
        {
            return new StatusDTO();
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<StatusDTO> ObterTodos()
        {
            return new List<StatusDTO>();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria()
        {
            return true;
        }

        [HttpPut]
        [ActionName("atualiza")]
        public StatusDTO Atualiza()
        {
            return new StatusDTO();
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove()
        {
            return true;
        }
    }
}
