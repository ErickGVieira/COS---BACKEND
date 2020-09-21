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
    public class OrdemDeServicoController: ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public OrdemDeServicoDTO Obter(int idOrdemDeServico)
        {
            return new ServicoOrdemDeServico().ObtemOrdemDeServico(idOrdemDeServico);
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<OrdemDeServicoDTO> ObterTodos()
        {
            return new ServicoOrdemDeServico().ObtemOrdensDeServico();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria(OrdemDeServicoDTO ordemDeServicoDTO)
        {
            return new ServicoOrdemDeServico().CriaOrdemDeServico(ordemDeServicoDTO);
        }

        [HttpPut]
        [ActionName("atualiza")]
        public OrdemDeServicoDTO Atualiza(OrdemDeServicoDTO ordemDeServicoDTO)
        {
            return new ServicoOrdemDeServico().AtualizaOrdemDeServico(ordemDeServicoDTO);
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove(int idOrdemDeServico)
        {
            return new ServicoOrdemDeServico().RemoveOrdemDeServico(idOrdemDeServico);
        }
    }
}
