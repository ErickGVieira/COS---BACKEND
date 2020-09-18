﻿using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Repositorios.SQL
{
    public interface IRepositorioOrdemDeServico
    {
        OrdemDeServicoDTO ObtemOrdemDeServico(int idOrdemDeServico);
        List<OrdemDeServicoDTO> ObtemOrdensDeServico();
        bool RemoveOrdemDeServico(int idOrdemDeServico);
        bool CriaOrdemDeServio(OrdemDeServicoDTO ordemDeServicoDTO);
        OrdemDeServicoDTO AtualizaOrdemDeServico(OrdemDeServicoDTO ordemDeServicoDTO);
    }
}
