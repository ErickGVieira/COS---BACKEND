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
    public class RepositorioCargo: IRepositorioCargo
    {
        public CargoDTO ObtemCargo(int idCargo)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<CargoDTO>(context.Cargo.FirstOrDefault(x => x.id == idCargo));
            }
        }
    }
}
