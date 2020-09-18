using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiApk.Controller
{
    public class ServicoController: ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public ServicoDTO Obter(int idOrdemDeServico)
        {
            return new ServicoDTO();
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<ServicoDTO> ObterTodos()
        {
            return new List<ServicoDTO>();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria()
        {
            return true;
        }

        [HttpPut]
        [ActionName("atualiza")]
        public ServicoDTO Atualiza()
        {
            return new ServicoDTO();
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove()
        {
            return true;
        }
    }
}
