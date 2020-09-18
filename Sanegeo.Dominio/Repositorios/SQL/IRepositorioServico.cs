using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Repositorios.SQL
{
    public interface IRepositorioServico
    {
        ServicoDTO ObtemServico(int idServico);
        List<ServicoDTO> ObtemServicos();
        bool RemoveServico(int idServico);
        bool CriaServico(ServicoDTO servicoDTO);
        ServicoDTO AtualizaServico(ServicoDTO servicoDTO);
    }
}
