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
    public class ServicoServico
    {
        private IRepositorioServico repositorioServico;

        public ServicoServico()
        {
            this.repositorioServico = new RepositorioServico();
        }

        public ServicoDTO ObtemServico(int idServico)
        {
            try
            {
                return repositorioServico.ObtemServico(idServico);
            }
            catch (Exception ex)
            {
                return new ServicoDTO();
            }
        }

        public List<ServicoDTO> ObtemServicos()
        {
            try
            {
                return repositorioServico.ObtemServicos();
            }
            catch (Exception ex)
            {
                return new List<ServicoDTO>();
            }
        }

        public bool CriarServico(ServicoDTO servicoDTO)
        {
            try
            {
                return repositorioServico.CriaServico(servicoDTO);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public ServicoDTO AtualizarServico(ServicoDTO servicoDTO)
        {
            try
            {
                return repositorioServico.AtualizaServico(servicoDTO);
            }
            catch (Exception ex)
            {
                return new ServicoDTO();
            }
        }

        public bool RemoverServico(int idServico)
        {
            try
            {
                return repositorioServico.RemoveServico(idServico);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
