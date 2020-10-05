using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Repositorios.SQL
{
    public interface IRepositorioAeronave
    {
        List<AeronaveDTO> ObtemAeronave();
        AeronaveDTO ObtemAeronave(string prefixAeronave);
        bool RemoveAeronave(string prefixAeronave);
        bool CriaAeronave(AeronaveDTO aeronaveDTO);
        AeronaveDTO AtualizaAeronave(AeronaveDTO aeronaveDTO);
    }
}
