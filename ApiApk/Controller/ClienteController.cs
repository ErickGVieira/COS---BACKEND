using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiApk.Controller
{
    public class ClienteController : ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public ClienteDTO Obter(int idCliente)
        {
            return new ClienteDTO();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria()
        {
            return true;
        }

        [HttpPut]
        [ActionName("atualiza")]
        public ClienteDTO Atualiza()
        {
            return new ClienteDTO();
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove()
        {
            return true;
        }
    }
}
