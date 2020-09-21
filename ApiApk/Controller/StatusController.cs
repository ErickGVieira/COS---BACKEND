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
    public class StatusController: ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public StatusDTO Obter(int idStatus)
        {
            return new ServicoStatus().ObtemStatus(idStatus);
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<StatusDTO> ObterTodos()
        {
            return new ServicoStatus().ObtemStatus();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria(StatusDTO statusDTO)
        {
            return new ServicoStatus().CriarStatus(statusDTO);
        }

        [HttpPut]
        [ActionName("atualiza")]
        public StatusDTO Atualiza(StatusDTO statusDTO)
        {
            return new ServicoStatus().AtualizarStatus(statusDTO);
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove(int idStatus)
        {
            return new ServicoStatus().RemoverStatus(idStatus);
        }
    }
}
