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
    public class RepositorioServico: IRepositorioServico
    {
        public ServicoDTO ObtemServico(int idServico)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<ServicoDTO>(context.Servico.FirstOrDefault(x => x.id == idServico));
            }
        }
    }
}
