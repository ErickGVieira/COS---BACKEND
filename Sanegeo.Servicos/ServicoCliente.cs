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
    public class ServicoCliente
    {
        private IRepositorioCliente repositorioCliente;

        public ServicoCliente()
        {
            this.repositorioCliente = new RepositorioCliente();
        }

        public ClienteDTO ObtemCliente(int idCliente)
        {
            try
            {
                return repositorioCliente.ObtemCliente(idCliente);
            }
            catch (Exception ex)
            {
                return new ClienteDTO();
            }
        }
    }
}
