using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Cos.Api.Controller
{
   
    public class UsuarioController : ApiController
    {
        [HttpGet]
        [ActionName("login")]
        public UsuarioDTO Login(string usuario, string senha)
        {
            return new UsuarioDTO();
        }

        [HttpGet]
        [ActionName("obtem")]
        public UsuarioDTO Obter(int idUsuario)
        {
            return new UsuarioDTO();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria()
        {
            return true;
        }

        [HttpPut]
        [ActionName("atualiza")]
        public UsuarioDTO Atualiza()
        {
            return new UsuarioDTO();
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove()
        {
            return true;
        }
    }
}
