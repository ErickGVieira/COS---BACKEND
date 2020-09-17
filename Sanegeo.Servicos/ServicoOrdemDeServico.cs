﻿using Cos.Dominio.Modelos;
using Cos.Dominio.Repositorios.SQL;
using Sanegeo.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanegeo.Servicos
{
    public class ServicoOrdemDeServico
    {
        private IRepositorioOrdemDeServico repositorioOrdemDeServico;

        public ServicoOrdemDeServico()
        {
            this.repositorioOrdemDeServico = new RepositorioOrdemDeServico();
        }

        public OrdemDeServicoDTO ObtemOrdemDeServico(int idOrdemDeServico)
        {
            try
            {
                return repositorioOrdemDeServico.ObtemOrdemDeServico(idOrdemDeServico);
            }
            catch (Exception ex)
            {
                return new OrdemDeServicoDTO();
            }
        }
    }
}
