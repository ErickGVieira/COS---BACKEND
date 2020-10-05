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
    public class ServicoAeronave
    {
        private IRepositorioAeronave repositorioAeronave;

        public ServicoAeronave()
        {
            this.repositorioAeronave = new RepositorioAeronave();
        }

        public AeronaveDTO ObtemAeronave(string prefixAeronave)
        {
            try
            {
                return repositorioAeronave.ObtemAeronave(prefixAeronave);
            }
            catch (Exception ex)
            {
                return new AeronaveDTO();
            }
        }

        public List<AeronaveDTO> ObtemAeronaves()
        {
            try
            {
                return repositorioAeronave.ObtemAeronave();
            }
            catch (Exception ex)
            {
                return new List<AeronaveDTO>();
            }
        }

        public bool CriaAeronave(AeronaveDTO aeronaveDTO)
        {
            try
            {
                return repositorioAeronave.CriaAeronave(aeronaveDTO);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemoveAeronave(string prefixAeronave)
        {
            try
            {
                return repositorioAeronave.RemoveAeronave(prefixAeronave);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public AeronaveDTO AtualizaAeronave(AeronaveDTO aeronaveDTO)
        {
            try
            {
                return repositorioAeronave.AtualizaAeronave(aeronaveDTO);
            }
            catch (Exception ex)
            {
                return new AeronaveDTO();
            }
        }
    }
}
