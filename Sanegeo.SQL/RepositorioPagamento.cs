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
    public class RepositorioPagamento: IRepositorioPagamento
    {
        public List<PagamentoDTO> ObtemPagamentos()
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<List<PagamentoDTO>>(context.Pagamento.ToList());
            }
        }

        public PagamentoDTO ObtemPagamento(int idPagamento)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<PagamentoDTO>(context.Pagamento.FirstOrDefault(x => x.id == idPagamento));
            }
        }

        public bool RemovePagamento(int idPagamento)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var pagamento = context.Pagamento.FirstOrDefault(x => x.id == idPagamento);
                    context.Pagamento.Remove(pagamento);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool CriaPagamento(PagamentoDTO pagamentoDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var pagamento = Mapper.Map<Pagamento>(pagamentoDTO);
                    context.Pagamento.Add(pagamento);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public PagamentoDTO AtualizaPagamento(PagamentoDTO pagamentoDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var pagamento = context.Pagamento.FirstOrDefault(x => x.id == pagamentoDTO.id);
                    pagamento.idTipoPagamento = pagamentoDTO.idTipoPagamento;
                    pagamento.valor = pagamentoDTO.valor;
                    context.Pagamento.Add(pagamento);

                    context.Entry(pagamento).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return Mapper.Map<PagamentoDTO>(pagamentoDTO);
                }
                catch (Exception ex)
                {
                    return new PagamentoDTO();
                }

            }
        }
    }
}
