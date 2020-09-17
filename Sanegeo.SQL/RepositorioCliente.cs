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
    public class RepositorioCliente: IRepositorioCliente
    {
        public ClienteDTO ObtemCliente(int idCliente)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<ClienteDTO>(context.Cliente.FirstOrDefault(x => x.id == idCliente));
            }
        }
    }
}
