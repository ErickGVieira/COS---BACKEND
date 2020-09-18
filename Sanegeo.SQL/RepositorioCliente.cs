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
    public class RepositorioCliente: IRepositorioCliente
    {
        public List<ClienteDTO> ObtemClientes()
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<List<ClienteDTO>>(context.Cliente.ToList());
            }
        }

        public ClienteDTO ObtemCliente(int idCliente)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                return Mapper.Map<ClienteDTO>(context.Cliente.FirstOrDefault(x => x.id == idCliente));
            }
        }

        public bool RemoveCliente(int idCliente)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var cliente = context.Cliente.FirstOrDefault(x => x.id == idCliente);
                    context.Cliente.Remove(cliente);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool CriaCliente(ClienteDTO clienteDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var cliente = Mapper.Map<Cliente>(clienteDTO);
                    context.Cliente.Add(cliente);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public ClienteDTO AtualizaCliente(ClienteDTO clienteDTO)
        {
            using (SanegeoEntities context = new SanegeoEntities())
            {
                try
                {
                    var cliente = context.Cliente.FirstOrDefault(x => x.id == clienteDTO.id);
                    cliente.cpf = clienteDTO.cpf;
                    cliente.email = clienteDTO.email;
                    cliente.nome = clienteDTO.nome;
                    cliente.telefone = clienteDTO.telefone;

                    context.Cliente.Add(cliente);

                    context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return Mapper.Map<ClienteDTO>(clienteDTO);
                }
                catch (Exception ex)
                {
                    return new ClienteDTO();
                }

            }
        }
    }
}
