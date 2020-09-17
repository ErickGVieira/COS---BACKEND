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
    public class ServicoUsuario
    {
        private IRepositorioUsuario repositorioUsuario;

        public ServicoUsuario()
        {
            this.repositorioUsuario = new RepositorioUsuario();
        }

        public UsuarioDTO ObtemUsuario(int idUsuario)
        {
            try
            {
                return repositorioUsuario.ObtemUsuario(idUsuario);
            }catch(Exception ex)
            {
                return new UsuarioDTO();
            }
        }
    }
}
