﻿using Cos.Dominio.Modelos;
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
    }
}