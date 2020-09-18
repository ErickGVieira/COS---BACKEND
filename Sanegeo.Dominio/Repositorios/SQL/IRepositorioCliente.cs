using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Repositorios.SQL
{
    public interface IRepositorioCliente
    {
        ClienteDTO ObtemCliente(int idCliente);
        List<ClienteDTO> ObtemClientes();
        bool RemoveCliente(int idCliente);
        bool CriaCliente(ClienteDTO clienteDTO);
        ClienteDTO AtualizaCliente(ClienteDTO clienteDTO);
    }
}
