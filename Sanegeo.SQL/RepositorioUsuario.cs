using AutoMapper;
using Cos.Dominio;
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
        public UsuarioDTO Login(string cpf, string senha)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<UsuarioDTO>(context.Usuario.FirstOrDefault(x => x.cpf == cpf && x.senha == senha));
            }
        }

        public List<UsuarioDTO> ObtemUsuarios()
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<List<UsuarioDTO>>(context.Usuario.ToList());
            }
        }

        public UsuarioDTO ObtemUsuario(int idUsuario)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<UsuarioDTO>(context.Usuario.FirstOrDefault(x => x.id == idUsuario));
            }
        }

        public bool RemoveUsuario(int idUsuario)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var usuario = context.Usuario.FirstOrDefault(x => x.id == idUsuario);
                    context.Usuario.Remove(usuario);
                    context.SaveChanges();

                    return true;
                }catch(Exception ex)
                {
                    return false;
                }
                
            }
        }

        public bool CriaUsuario(UsuarioDTO usuarioDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var usuario = Mapper.Map<Usuario>(usuarioDTO);
                    context.Usuario.Add(usuario);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public UsuarioDTO AtualizaUsuario(UsuarioDTO usuarioDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var usuario = context.Usuario.FirstOrDefault(x=>x.id == usuarioDTO.id);
                    usuario.cpf = usuarioDTO.cpf;
                    usuario.idCargo = usuarioDTO.idCargo;
                    usuario.nome = usuarioDTO.nome;
                    usuario.senha = usuario.senha;
                    context.Usuario.Add(usuario);

                    context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return Mapper.Map<UsuarioDTO>(usuarioDTO);
                }
                catch (Exception ex)
                {
                    return new UsuarioDTO();
                }
            }
        }
    }
}
