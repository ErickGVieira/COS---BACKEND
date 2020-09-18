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
    public class RepositorioStatus: IRepositorioStatus
    {
        private object tipoPagamentoDTO;

        public List<StatusDTO> ObtemStatus()
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<List<StatusDTO>>(context.Status.ToList());
            }
        }

        public StatusDTO ObtemStatus(int idStatus)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<StatusDTO>(context.Status.FirstOrDefault(x => x.id == idStatus));
            }
        }

        public bool RemoveStatus(int idStatus)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var status = context.Status.FirstOrDefault(x => x.id == idStatus);
                    context.Status.Remove(status);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool CriaStatus(StatusDTO statusDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var status = Mapper.Map<Status>(statusDTO);
                    context.Status.Add(status);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public StatusDTO AtualizaStatus(StatusDTO statusDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var status = context.Status.FirstOrDefault(x => x.id == statusDTO.id);
                    status.descricao = statusDTO.descricao;
                    context.Status.Add(status);

                    context.Entry(status).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return Mapper.Map<StatusDTO>(statusDTO);
                }
                catch (Exception ex)
                {
                    return new StatusDTO();
                }

            }
        }
    }
}
