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
    public class ServicoPeca
    {
        private IRepositorioPeca repositorioPeca;

        public ServicoPeca()
        {
            this.repositorioPeca = new RepositorioPeca();
        }

        public PecaDTO ObtemPeca(int idPeca)
        {
            try
            {
                return repositorioPeca.ObtemPeca(idPeca);
            }
            catch (Exception ex)
            {
                return new PecaDTO();
            }
        }

        public List<PecaDTO> ObtemPecas()
        {
            try
            {
                return repositorioPeca.ObtemPecas();
            }
            catch (Exception ex)
            {
                return new List<PecaDTO>();
            }
        }

        public bool CriarPeca(PecaDTO pecaDTO)
        {
            try
            {
                return repositorioPeca.CriaPeca(pecaDTO);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public PecaDTO AtualizarPeca(PecaDTO pecaDTO)
        {
            try
            {
                return repositorioPeca.AtualizaPeca(pecaDTO);
            }
            catch (Exception ex)
            {
                return new PecaDTO();
            }
        }

        public bool RemoverPeca(int idPeca)
        {
            try
            {
                return repositorioPeca.RemovePeca(idPeca);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
