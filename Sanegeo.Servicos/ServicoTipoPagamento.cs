using Cos.Dominio.Modelos;
using Cos.Dominio.Repositorios.SQL;
using Sanegeo.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanegeo.Servicos
{
    public class ServicoTipoPagamento
    {
        private IRepositorioTipoPagamento repositorioTipoPagamento;

        public ServicoTipoPagamento()
        {
            this.repositorioTipoPagamento = new RepositorioTipoPagamento();
        }

        public TipoPagamentoDTO ObtemTipoPagamento(int idTipoPagamento)
        {
            try
            {
                return repositorioTipoPagamento.ObtemTipoPagamento(idTipoPagamento);
            }
            catch (Exception ex)
            {
                return new TipoPagamentoDTO();
            }
        }

        public List<TipoPagamentoDTO> ObtemTiposPagamento()
        {
            try
            {
                return repositorioTipoPagamento.ObtemTiposPagamento();
            }
            catch (Exception ex)
            {
                return new List<TipoPagamentoDTO>();
            }
        }

        public bool CriarTipoPagamento(TipoPagamentoDTO tipoPagamentoDTO)
        {
            try
            {
                return repositorioTipoPagamento.CriaTipoPagamento(tipoPagamentoDTO);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public bool RemoverTipoPagamento(int idTipoPagamento)
        {
            try
            {
                return repositorioTipoPagamento.RemoveTipoPagamento(idTipoPagamento);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public TipoPagamentoDTO AtualizarTipoPagamento(TipoPagamentoDTO tipoPagamentoDTO)
        {
            try
            {
                return repositorioTipoPagamento.AtualizaTipoPagamento(tipoPagamentoDTO);
            }
            catch (Exception ex)
            {
                return new TipoPagamentoDTO();
            }
        }
    }
}
