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
    public class PecaController: ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public PecaDTO Obter(int idPeca)
        {
            return new ServicoPeca().ObtemPeca(idPeca);
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<PecaDTO> ObterTodos()
        {
            return new ServicoPeca().ObtemPecas();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria(PecaDTO pecaDTO)
        {
            return new ServicoPeca().CriarPeca(pecaDTO);
        }

        [HttpPut]
        [ActionName("atualiza")]
        public PecaDTO Atualiza(PecaDTO pecaDTO)
        {
            return new ServicoPeca().AtualizarPeca(pecaDTO);
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove(int idPeca)
        {
            return new ServicoPeca().RemoverPeca(idPeca);
        }
    }
}
