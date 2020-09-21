using Cos.Dominio.Modelos;
using Sanegeo.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiApk.Controller
{
    public class ClienteController : ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public ClienteDTO Obter(int idCliente)
        {
            return new ServicoCliente().ObtemCliente(idCliente);
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<ClienteDTO> ObterTodos()
        {
            return new ServicoCliente().ObtemClientes();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria(ClienteDTO clienteDTO)
        {
            return new ServicoCliente().CriaCliente(clienteDTO);
        }

        [HttpPut]
        [ActionName("atualiza")]
        public ClienteDTO Atualiza(ClienteDTO clienteDTO)
        {
            return new ServicoCliente().AtualizaCliente(clienteDTO);
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove(int idCliente)
        {
            return new ServicoCliente().RemoveCliente(idCliente);
        }
    }
}
