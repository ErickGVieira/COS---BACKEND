using Cos.Dominio.Modelos;
using Sanegeo.Servicos;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Cos.Api.Controller
{
   
    public class UsuarioController : ApiController
    {
        [HttpGet]
        [ActionName("login")]
        public UsuarioDTO Login(string cpf, string senha)
        {
            return new ServicoUsuario().Login(cpf, senha);
        }

        [HttpGet]
        [ActionName("obtem")]
        public UsuarioDTO Obter(int idUsuario)
        {
            return new ServicoUsuario().ObtemUsuario(idUsuario);
        }
        
        [HttpGet]
        [ActionName("obtemTodos")]
        public List<UsuarioDTO> ObterTodos()
        {
            return new ServicoUsuario().ObtemUsuarios();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria(UsuarioDTO usuario)
        {
            return new ServicoUsuario().CriaUsuario(usuario);
        }

        [HttpPut]
        [ActionName("atualiza")]
        public UsuarioDTO Atualiza(UsuarioDTO usuario)
        {
            return new ServicoUsuario().AtualizarUsuario(usuario);
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove(int idUsuario)
        {
            return new ServicoUsuario().RemoveUsuario(idUsuario);
        }
    }
}
