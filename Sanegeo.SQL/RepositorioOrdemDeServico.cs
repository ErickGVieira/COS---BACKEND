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
    public class RepositorioOrdemDeServico: IRepositorioOrdemDeServico
    {
        public List<OrdemDeServicoDTO> ObtemOrdensDeServico()
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<List<OrdemDeServicoDTO>>(context.OrdemDeServico.ToList());
            }
        }

        public OrdemDeServicoDTO ObtemOrdemDeServico(int idOrdemDeServico)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<OrdemDeServicoDTO>(context.OrdemDeServico.FirstOrDefault(x => x.id == idOrdemDeServico));
            }
        }

        public bool RemoveOrdemDeServico(int idOrdemDeServico)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var ordemDeServico = context.OrdemDeServico.FirstOrDefault(x => x.id == idOrdemDeServico);
                    context.OrdemDeServico.Remove(ordemDeServico);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool CriaOrdemDeServio(OrdemDeServicoDTO ordemDeServicoDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var ordemDeServico = Mapper.Map<OrdemDeServico>(ordemDeServicoDTO);
                    ordemDeServico.dataInicio = DateTime.Now;
                    context.OrdemDeServico.Add(ordemDeServico);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }
        public OrdemDeServicoDTO AtualizaOrdemDeServico(OrdemDeServicoDTO ordemDeServicoDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var ordemDeServico = context.OrdemDeServico.FirstOrDefault(x => x.id == ordemDeServicoDTO.id);
                    ordemDeServico.dataFim = ordemDeServicoDTO.dataFim;
                    ordemDeServico.dataInicio = ordemDeServicoDTO.dataInicio;
                    ordemDeServico.idCliente = ordemDeServicoDTO.idCliente;
                    ordemDeServico.idExecutor = ordemDeServicoDTO.idExecutor;
                    ordemDeServico.idServicoExecutado = ordemDeServicoDTO.idServicoExecutado;
                    ordemDeServico.idServicoSolicitado = ordemDeServicoDTO.idServicoSolicitado;
                    ordemDeServico.idStatus = ordemDeServicoDTO.idStatus;
                    context.OrdemDeServico.Add(ordemDeServico);

                    context.Entry(ordemDeServico).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return Mapper.Map<OrdemDeServicoDTO>(ordemDeServicoDTO);
                }
                catch (Exception ex)
                {
                    return new OrdemDeServicoDTO();
                }

            }
        }
    }
}
