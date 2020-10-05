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
    public class AeronaveController : ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public AeronaveDTO Obter(string prefixAeronave)
        {
            return new ServicoAeronave().ObtemAeronave(prefixAeronave);
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<AeronaveDTO> ObterTodos()
        {
            return new ServicoAeronave().ObtemAeronaves();
        }

        [HttpGet]
        [ActionName("obtemTodosAtivos")]
        public List<AeronaveDTO> ObterTodosAtivos()
        {
            return new ServicoAeronave().ObtemAeronaves().Where(x=>x.ACTIVE == true).ToList();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria(AeronaveDTO aeronaveDTO)
        {
            return new ServicoAeronave().CriaAeronave(aeronaveDTO);
        }

        [HttpPut]
        [ActionName("atualiza")]
        public AeronaveDTO Atualiza(AeronaveDTO aeronaveDTO)
        {
            return new ServicoAeronave().AtualizaAeronave(aeronaveDTO);
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove(string prefixAeronave)
        {
            return new ServicoAeronave().RemoveAeronave(prefixAeronave);
        }
    }
}
