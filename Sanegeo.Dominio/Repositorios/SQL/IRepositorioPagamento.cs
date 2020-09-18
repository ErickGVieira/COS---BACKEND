using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Repositorios.SQL
{
    public interface IRepositorioPagamento
    {
        PagamentoDTO ObtemPagamento(int idPagamento);
        List<PagamentoDTO> ObtemPagamentos();
        bool RemovePagamento(int idPagamento);
        bool CriaPagamento(PagamentoDTO pagamentoDTO);
        PagamentoDTO AtualizaPagamento(PagamentoDTO pagamentoDTO);
    }
}
