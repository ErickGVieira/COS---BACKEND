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
    public class RepositorioPeca: IRepositorioPeca
    {
        public PecaDTO ObtemPeca(int idPeca)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<PecaDTO>(context.Peca.FirstOrDefault(x => x.id == idPeca));
            }
        }
    }
}
