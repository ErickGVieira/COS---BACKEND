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
    }
}
