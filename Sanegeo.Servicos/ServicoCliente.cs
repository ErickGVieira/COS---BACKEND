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

        public List<ClienteDTO> ObtemClientes()
        {
            try
            {
                return repositorioCliente.ObtemClientes();
            }
            catch (Exception ex)
            {
                return new List<ClienteDTO>();
            }
        }

        public bool CriaCliente(ClienteDTO clienteDTO)
        {
            try
            {
                return repositorioCliente.CriaCliente(clienteDTO);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ClienteDTO AtualizaCliente(ClienteDTO clienteDTO)
        {
            try
            {
                return repositorioCliente.AtualizaCliente(clienteDTO);
            }
            catch (Exception ex)
            {
                return new ClienteDTO();
            }
        }

        public bool RemoveCliente(int idCliente)
        {
            try
            {
                return repositorioCliente.RemoveCliente(idCliente);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
