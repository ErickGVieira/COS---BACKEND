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
    public class ServicoStatus
    {
        private IRepositorioStatus repositorioStatus;

        public ServicoStatus()
        {
            this.repositorioStatus = new RepositorioStatus();
        }

        public StatusDTO ObtemStatus(int idStatus)
        {
            try
            {
                return repositorioStatus.ObtemStatus(idStatus);
            }
            catch (Exception ex)
            {
                return new StatusDTO();
            }
        }

        public List<StatusDTO> ObtemStatus()
        {
            try
            {
                return repositorioStatus.ObtemStatus();
            }
            catch (Exception ex)
            {
                return new List<StatusDTO>();
            }
        }

        public bool CriarStatus(StatusDTO statusDTO)
        {
            try
            {
                return repositorioStatus.CriaStatus(statusDTO);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public StatusDTO AtualizarStatus(StatusDTO statusDTO)
        {
            try
            {
                return repositorioStatus.AtualizaStatus(statusDTO);
            }
            catch (Exception ex)
            {
                return new StatusDTO();
            }
        }
        
        public bool RemoverStatus(int idStatus)
        {
            try
            {
                return repositorioStatus.RemoveStatus(idStatus);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
