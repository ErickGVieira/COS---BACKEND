using AutoMapper;
using Cos.Dominio.Modelos;
using Cos.Dominio.Repositorios.SQL;
using Sanegeo.SQL.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sanegeo.SQL
{
    public class RepositorioModelo: IRepositorioModelo
    {
        public List<ModeloDTO> ObtemModelos()
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<List<ModeloDTO>>(context.Modeloes.ToList());
            }
        }

        public ModeloDTO ObtemModelos(string code)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<ModeloDTO>(context.Modeloes.FirstOrDefault(x => x.CODE == code));
            }
        }
        public bool RemoveModelo(string code)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var modelo = context.Modeloes.FirstOrDefault(x => x.CODE == code);
                    context.Modeloes.Remove(modelo);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool CriaModelo(ModeloDTO modeloDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var modelo = Mapper.Map<Sanegeo.Dominio.Modelo>(modeloDTO);
                    context.Modeloes.Add(modelo);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public ModeloDTO AtualizaModelo(ModeloDTO modeloDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var modelo = context.Modeloes.FirstOrDefault(x => x.CODE == modeloDTO.CODE);
                    modelo.ALTERNATIVE_CODE = modeloDTO.ALTERNATIVE_CODE;
                    modelo.MAX_DEPARTURE_WEIGHT = modeloDTO.MAX_DEPARTURE_WEIGHT;
                    modelo.MAX_LANDING_WEIGHT = modeloDTO.MAX_LANDING_WEIGHT;

                    context.Modeloes.Add(modelo);

                    context.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return Mapper.Map<ModeloDTO>(modelo);
                }
                catch (Exception ex)
                {
                    return new ModeloDTO();
                }

            }
        }
    }
}
