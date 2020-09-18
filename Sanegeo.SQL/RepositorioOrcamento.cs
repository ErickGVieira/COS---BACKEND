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
    public class RepositorioOrcamento: IRepositorioOrcamento
    {
        public List<OrcamentoDTO> ObtemOrcamentos()
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<List<OrcamentoDTO>>(context.Orcamento.ToList());
            }
        }

        public OrcamentoDTO ObtemOrcamento(int idOrcamento)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<OrcamentoDTO>(context.Orcamento.FirstOrDefault(x => x.id == idOrcamento));
            }
        }

        public bool RemoveOrcamento(int idOrcamento)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var orcamento = context.Orcamento.FirstOrDefault(x => x.id == idOrcamento);
                    context.Orcamento.Remove(orcamento);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool CriaOrcamento(OrcamentoDTO orcamentoDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var orcamento = Mapper.Map<Orcamento>(orcamentoDTO);
                    context.Orcamento.Add(orcamento);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public OrcamentoDTO AtualizaOrcamento(OrcamentoDTO orcamentoDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var orcamento = context.Orcamento.FirstOrDefault(x => x.id == orcamentoDTO.id);
                    orcamento.descricao = orcamentoDTO.descricao;
                    orcamento.valor = orcamentoDTO.valor;

                    context.Orcamento.Add(orcamento);

                    context.Entry(orcamento).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return Mapper.Map<OrcamentoDTO>(orcamentoDTO);
                }
                catch (Exception ex)
                {
                    return new OrcamentoDTO();
                }

            }
        }
    }
}
