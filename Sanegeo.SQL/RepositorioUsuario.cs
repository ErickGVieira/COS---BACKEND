﻿using AutoMapper;
using Cos.Dominio.Modelos;
using Cos.Dominio.Repositorios.SQL;
using Sanegeo.SQL.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanegeo.SQL
{
    public class RepositorioUsuario : IRepositorioUsuario 
    {
        public UsuarioDTO ObtemUsuario(int idUsuario)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<UsuarioDTO>(context.Usuario.FirstOrDefault(x => x.id == idUsuario));
            }
        }
    }
}