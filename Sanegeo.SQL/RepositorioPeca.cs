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
    public class RepositorioPeca: IRepositorioPeca
    {
        public List<PecaDTO> ObtemPecas()
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<List<PecaDTO>>(context.Peca.ToList());
            }
        }

        public PecaDTO ObtemPeca(int idPeca)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<PecaDTO>(context.Peca.FirstOrDefault(x => x.id == idPeca));
            }
        }

        public bool RemovePeca(int idPeca)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var peca = context.Peca.FirstOrDefault(x => x.id == idPeca);
                    context.Peca.Remove(peca);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public PecaDTO AtualizaPeca(PecaDTO pecaDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var peca = context.Peca.FirstOrDefault(x => x.id == pecaDTO.id);
                    peca.descricao = pecaDTO.descricao;
                    context.Peca.Add(peca);

                    context.Entry(peca).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return Mapper.Map<PecaDTO>(pecaDTO);
                }
                catch (Exception ex)
                {
                    return new PecaDTO();
                }
            }
        }

        public bool CriaPeca(PecaDTO pecaDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var peca = Mapper.Map<Peca>(pecaDTO);
                    context.Peca.Add(peca);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }
    }
}
