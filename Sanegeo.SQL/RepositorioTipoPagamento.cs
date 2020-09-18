using AutoMapper;
using Cos.Dominio;
using Cos.Dominio.Modelos;
using Cos.Dominio.Repositorios.SQL;
using Sanegeo.SQL.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanegeo.SQL
{
    public class RepositorioTipoPagamento: IRepositorioTipoPagamento
    {
        public List<TipoPagamentoDTO> ObtemTiposPagamento()
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<List<TipoPagamentoDTO>>(context.TipoPagamento.ToList());
            }
        }

        public TipoPagamentoDTO ObtemTipoPagamento(int idTipoPagamento)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<TipoPagamentoDTO>(context.TipoPagamento.FirstOrDefault(x => x.id == idTipoPagamento));
            }
        }

        public bool RemoveTipoPagamento(int idTipoPagamento)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var tipoPagamento = context.TipoPagamento.FirstOrDefault(x => x.id == idTipoPagamento);
                    context.TipoPagamento.Remove(tipoPagamento);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool CriaTipoPagamento(TipoPagamentoDTO tipoPagamentoDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var tipoPagamento = Mapper.Map<TipoPagamento>(tipoPagamentoDTO);
                    context.TipoPagamento.Add(tipoPagamento);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public TipoPagamentoDTO AtualizaTipoPagamento (TipoPagamentoDTO tipoPagamentoDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var tipoPagamento = context.TipoPagamento.FirstOrDefault(x => x.id == tipoPagamentoDTO.id);
                    tipoPagamento.descricao = tipoPagamentoDTO.descricao;
                    context.TipoPagamento.Add(tipoPagamento);

                    context.Entry(tipoPagamento).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return Mapper.Map<TipoPagamentoDTO>(tipoPagamentoDTO);
                }
                catch (Exception ex)
                {
                    return new TipoPagamentoDTO();
                }

            }
        }
    }
}
