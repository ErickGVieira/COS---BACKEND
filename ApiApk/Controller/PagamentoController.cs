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
    public class PagamentoController: ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public PagamentoDTO Obter(int idPagamento)
        {
            return new ServicoPagamento().ObtemPagamento(idPagamento);
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<PagamentoDTO> ObterTodos()
        {
            return new ServicoPagamento().ObtemPagamentos();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria(PagamentoDTO pagamentoDTO)
        {
            return new ServicoPagamento().CriaPagamento(pagamentoDTO);
        }

        [HttpPut]
        [ActionName("atualiza")]
        public PagamentoDTO Atualiza(PagamentoDTO pagamentoDTO)
        {
            return new ServicoPagamento().AtualizarPagamento(pagamentoDTO);
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove(int idPagamento)
        {
            return new ServicoPagamento().RemoverPagamento(idPagamento);
        }
    }
}
