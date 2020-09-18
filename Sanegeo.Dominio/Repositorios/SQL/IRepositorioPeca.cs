using Cos.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Repositorios.SQL
{
    public interface IRepositorioPeca
    {
        PecaDTO ObtemPeca(int idPeca);
        List<PecaDTO> ObtemPecas();
        bool RemovePeca(int idPeca);
        PecaDTO AtualizaPeca(PecaDTO pecaDTO);
        bool CriaPeca(PecaDTO pecaDTO);
    }
}
