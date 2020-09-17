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
    public class RepositorioOrdemDeServico: IRepositorioOrdemDeServico
    {
        public OrdemDeServicoDTO ObtemOrdemDeServico(int idOrdemDeServico)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<OrdemDeServicoDTO>(context.OrdemDeServico.FirstOrDefault(x => x.id == idOrdemDeServico));
            }
        }
    }
}
