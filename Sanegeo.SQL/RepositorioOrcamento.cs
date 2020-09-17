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
    public class RepositorioOrcamento: IRepositorioOrcamento
    {
        public OrcamentoDTO ObtemOrcamento(int idOrcamento)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<OrcamentoDTO>(context.Orcamento.FirstOrDefault(x => x.id == idOrcamento));
            }
        }
    }
}
