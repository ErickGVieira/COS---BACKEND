using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Repositorios.SQL
{
    public interface IRepositorioModelo
    {
        List<ModeloDTO> ObtemModelos();
        ModeloDTO ObtemModelos(string code);
        bool RemoveModelo(string code);
        bool CriaModelo(ModeloDTO modeloDTO);
        ModeloDTO AtualizaModelo(ModeloDTO modeloDTO);
    }
}
