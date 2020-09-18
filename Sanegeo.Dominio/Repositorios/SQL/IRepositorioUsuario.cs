using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Repositorios.SQL
{
    public interface IRepositorioUsuario
    {
        UsuarioDTO ObtemUsuario(int idUsuario);
        List<UsuarioDTO> ObtemUsuarios();
        bool RemoveUsuario(int idUsuario);
        bool CriaUsuario(UsuarioDTO usuarioDTO);
        UsuarioDTO AtualizaUsuario(UsuarioDTO usuarioDTO);
        UsuarioDTO Login(string cpf, string senha);
    }
}
