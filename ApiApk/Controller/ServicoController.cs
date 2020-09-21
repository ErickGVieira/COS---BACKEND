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
    public class ServicoController: ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public ServicoDTO Obter(int idServico)
        {
            return new ServicoServico().ObtemServico(idServico);
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<ServicoDTO> ObterTodos()
        {
            return new ServicoServico().ObtemServicos();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria(ServicoDTO servicoDTO)
        {
            return new ServicoServico().CriarServico(servicoDTO);
        }

        [HttpPut]
        [ActionName("atualiza")]
        public ServicoDTO Atualiza(ServicoDTO servicoDTO)
        {
            return new ServicoServico().AtualizarServico(servicoDTO);
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove(int idServico)
        {
            return new ServicoServico().RemoverServico(idServico);
        }
    }
}
