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
    public class RepositorioServico: IRepositorioServico
    {
        public List<ServicoDTO> ObtemServicos()
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<List<ServicoDTO>>(context.Servico.ToList());
            }
        }

        public ServicoDTO ObtemServico(int idServico)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<ServicoDTO>(context.Servico.FirstOrDefault(x => x.id == idServico));
            }
        }

        public bool RemoveServico(int idServico)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var servico = context.Servico.FirstOrDefault(x => x.id == idServico);
                    context.Servico.Remove(servico);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool CriaServico(ServicoDTO servicoDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var servico = Mapper.Map<Servico>(servicoDTO);
                    context.Servico.Add(servico);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }
        public ServicoDTO AtualizaServico(ServicoDTO servicoDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var servico = context.Servico.FirstOrDefault(x => x.id == servicoDTO.id);
                    servico.descricao = servicoDTO.descricao;
                    context.Servico.Add(servico);

                    context.Entry(servico).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return Mapper.Map<ServicoDTO>(servicoDTO);
                }
                catch (Exception ex)
                {
                    return new ServicoDTO();
                }

            }
        }

    }
}
