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
    public class RepositorioCargo: IRepositorioCargo
    {
        public List<CargoDTO> ObtemCargos()
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<List<CargoDTO>>(context.Cargo.ToList());
            }
        }

        public CargoDTO ObtemCargo(int idCargo)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<CargoDTO>(context.Cargo.FirstOrDefault(x => x.id == idCargo));
            }
        }
        public bool RemoveCargo(int idCargo)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var cargo = context.Cargo.FirstOrDefault(x => x.id == idCargo);
                    context.Cargo.Remove(cargo);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool CriaCargo(CargoDTO cargoDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var cargo = Mapper.Map<Cargo>(cargoDTO);
                    context.Cargo.Add(cargo);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public CargoDTO AtualizaCargo(CargoDTO cargoDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var cargo = context.Cargo.FirstOrDefault(x => x.id == cargoDTO.id);
                    cargo.descricao = cargoDTO.descricao;

                    context.Cargo.Add(cargo);

                    context.Entry(cargo).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return Mapper.Map<CargoDTO>(cargoDTO);
                }
                catch (Exception ex)
                {
                    return new CargoDTO();
                }

            }
        }
    }
}
