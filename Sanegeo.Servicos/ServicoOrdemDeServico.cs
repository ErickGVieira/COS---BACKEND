using Cos.Dominio.Modelos;
using Cos.Dominio.Repositorios.SQL;
using Sanegeo.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanegeo.Servicos
{
    public class ServicoOrdemDeServico
    {
        private IRepositorioOrdemDeServico repositorioOrdemDeServico;

        public ServicoOrdemDeServico()
        {
            this.repositorioOrdemDeServico = new RepositorioOrdemDeServico();
        }

        public OrdemDeServicoDTO ObtemOrdemDeServico(int idOrdemDeServico)
        {
            try
            {
                return repositorioOrdemDeServico.ObtemOrdemDeServico(idOrdemDeServico);
            }
            catch (Exception ex)
            {
                return new OrdemDeServicoDTO();
            }
        }

        public List<OrdemDeServicoDTO> ObtemOrdensDeServico()
        {
            try
            {
                return repositorioOrdemDeServico.ObtemOrdensDeServico();
            }
            catch (Exception ex)
            {
                return new List<OrdemDeServicoDTO>();
            }
        }

        public bool CriaOrdemDeServico(OrdemDeServicoDTO ordemDeServicoDTO) 
        {
            try
            {
                return repositorioOrdemDeServico.CriaOrdemDeServio(ordemDeServicoDTO);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public OrdemDeServicoDTO AtualizaOrdemDeServico(OrdemDeServicoDTO ordemDeServicoDTO)
        {
            try
            {
                return repositorioOrdemDeServico.AtualizaOrdemDeServico(ordemDeServicoDTO);
            }
            catch (Exception ex)
            {
                return new OrdemDeServicoDTO();
            }
        }

        public bool RemoveOrdemDeServico(int idOrdemDeServico)
        {
            try
            {
                return repositorioOrdemDeServico.RemoveOrdemDeServico(idOrdemDeServico);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
