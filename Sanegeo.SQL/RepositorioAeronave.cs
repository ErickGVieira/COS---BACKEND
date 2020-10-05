using AutoMapper;
using Cos.Dominio.Modelos;
using Cos.Dominio.Repositorios.SQL;
using Sanegeo.Dominio;
using Sanegeo.SQL.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanegeo.SQL
{
    public class RepositorioAeronave: IRepositorioAeronave
    {
        public List<AeronaveDTO> ObtemAeronave()
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<List<AeronaveDTO>>(context.Aeronaves.ToList());
            }
        }

        public AeronaveDTO ObtemAeronave(string prefixAeronave)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<AeronaveDTO>(context.Aeronaves.FirstOrDefault(x => x.PREFIX == prefixAeronave));
            }
        }
        public bool RemoveAeronave(string prefixAeronave)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var aeronave = context.Aeronaves.FirstOrDefault(x => x.PREFIX == prefixAeronave);
                    context.Aeronaves.Remove(aeronave);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool CriaAeronave(AeronaveDTO aeronaveDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var aeronave = Mapper.Map<Aeronave>(aeronaveDTO);
                    context.Aeronaves.Add(aeronave);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public AeronaveDTO AtualizaAeronave(AeronaveDTO aeronaveDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var aeronave = context.Aeronaves.FirstOrDefault(x => x.PREFIX == aeronaveDTO.PREFIX);
                    aeronave.MAX_DEPARTURE_WEIGHT = aeronaveDTO.MAX_DEPARTURE_WEIGHT;
                    aeronave.MAX_LANDING_WEIGHT = aeronaveDTO.MAX_LANDING_WEIGHT;
                    aeronave.ACTIVE = aeronaveDTO.ACTIVE;
                    aeronave.AIRCRAFT_MODEL = aeronaveDTO.AIRCRAFT_MODEL;
                    aeronave.PASSENGERS_COUNT_AIRCRAFT = aeronaveDTO.PASSENGERS_COUNT_AIRCRAFT;

                    context.Aeronaves.Add(aeronave);

                    context.Entry(aeronave).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return Mapper.Map<AeronaveDTO>(aeronave);
                }
                catch (Exception ex)
                {
                    return new AeronaveDTO();
                }

            }
        }
    }
}
