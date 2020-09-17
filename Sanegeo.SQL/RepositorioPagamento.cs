using AutoMapper;
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
        public PagamentoDTO ObtemPagamento(int idPagamento)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<PagamentoDTO>(context.Pagamento.FirstOrDefault(x => x.id == idPagamento));
            }
        }
    }
}
