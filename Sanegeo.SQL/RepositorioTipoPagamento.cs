﻿using AutoMapper;
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
        public TipoPagamentoDTO ObtemTipoPagamento(int idTipoPagamento)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<TipoPagamentoDTO>(context.TipoPagamento.FirstOrDefault(x => x.id == idTipoPagamento));
            }
        }
    }
}
