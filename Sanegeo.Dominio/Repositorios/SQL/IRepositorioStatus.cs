using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Repositorios.SQL
{
    public interface IRepositorioStatus
    {
        StatusDTO ObtemStatus(int idStatus);
        List<StatusDTO> ObtemStatus();
        bool RemoveStatus(int idStatus);
        bool CriaStatus(StatusDTO statusDTO);
        StatusDTO AtualizaStatus(StatusDTO statusDTO);
    }
}
