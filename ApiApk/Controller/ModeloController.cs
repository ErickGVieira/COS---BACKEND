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
    public class ModeloController : ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public ModeloDTO Obter(string code)
        {
            return new ServicoModelo().ObtemModelo(code);
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<ModeloDTO> ObterTodos()
        {
            return new ServicoModelo().ObtemModelos();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria(ModeloDTO modeloDTO)
        {
            return new ServicoModelo().CriaModelo(modeloDTO);
        }

        [HttpPut]
        [ActionName("atualiza")]
        public ModeloDTO Atualiza(ModeloDTO aeronaveDTO)
        {
            return new ServicoModelo().AtualizaModelo(aeronaveDTO);
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove(string code)
        {
            return new ServicoModelo().RemoveModelo(code);
        }
    }
}
