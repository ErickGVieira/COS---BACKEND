using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Repositorios.SQL
{
    public interface IRepositorioTipoPagamento
    {
        TipoPagamentoDTO ObtemTipoPagamento(int idTipoPagamento);
        List<TipoPagamentoDTO> ObtemTiposPagamento();
        bool RemoveTipoPagamento(int idTipoPagamento);
        bool CriaTipoPagamento(TipoPagamentoDTO tipoPagamentoDTO);
        TipoPagamentoDTO AtualizaTipoPagamento(TipoPagamentoDTO tipoPagamentoDTO);
    }
}
