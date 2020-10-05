using Cos.Dominio.Modelos;
using Cos.Dominio.Repositorios.SQL;
using Sanegeo.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanegeo.Servicos
{
    public class ServicoModelo
    {
        private IRepositorioModelo repositorioModelo;

        public ServicoModelo()
        {
            this.repositorioModelo = new RepositorioModelo();
        }

        public ModeloDTO ObtemModelo(string code)
        {
            try
            {
                return repositorioModelo.ObtemModelos(code);
            }
            catch (Exception ex)
            {
                return new ModeloDTO();
            }
        }

        public List<ModeloDTO> ObtemModelos()
        {
            try
            {
                return repositorioModelo.ObtemModelos();
            }
            catch (Exception ex)
            {
                return new List<ModeloDTO>();
            }
        }

        public bool CriaModelo(ModeloDTO modeloDTO)
        {
            try
            {
                return repositorioModelo.CriaModelo(modeloDTO);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemoveModelo(string code)
        {
            try
            {
                return repositorioModelo.RemoveModelo(code);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ModeloDTO AtualizaModelo(ModeloDTO modeloDTO)
        {
            try
            {
                return repositorioModelo.AtualizaModelo(modeloDTO);
            }
            catch (Exception ex)
            {
                return new ModeloDTO();
            }
        }
    }
}
