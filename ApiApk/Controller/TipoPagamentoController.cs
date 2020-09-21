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
    public class TipoPagamentoController: ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public TipoPagamentoDTO Obter(int idTipoPagamento)
        {
            return new ServicoTipoPagamento().ObtemTipoPagamento(idTipoPagamento);
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<TipoPagamentoDTO> ObterTodos()
        {
            return new ServicoTipoPagamento().ObtemTiposPagamento();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria(TipoPagamentoDTO tipoPagamentoDTO)
        {
            return new ServicoTipoPagamento().CriarTipoPagamento(tipoPagamentoDTO);
        }

        [HttpPut]
        [ActionName("atualiza")]
        public TipoPagamentoDTO Atualiza(TipoPagamentoDTO tipoPagamentoDTO)
        {
            return new ServicoTipoPagamento().AtualizarTipoPagamento(tipoPagamentoDTO);
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove(int idTipoPagamento)
        {
            return new ServicoTipoPagamento().RemoverTipoPagamento(idTipoPagamento);
        }
    }
}
