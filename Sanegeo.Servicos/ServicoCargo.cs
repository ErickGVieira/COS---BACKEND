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
    public class ServicoCargo
    {
        private IRepositorioCargo repositorioCargo;

        public ServicoCargo()
        {
            this.repositorioCargo = new RepositorioCargo();
        }

        public CargoDTO ObtemCargo(int idCargo)
        {
            try
            {
                return repositorioCargo.ObtemCargo(idCargo);
            }
            catch (Exception ex)
            {
                return new CargoDTO();
            }
        }

        public List<CargoDTO> ObtemCargos()
        {
            try
            {
                return repositorioCargo.ObtemCargos();
            }
            catch (Exception ex)
            {
                return new List<CargoDTO>();
            }
        }

        public bool CriaCargo(CargoDTO cargoDTO)
        {
            try
            {
                return repositorioCargo.CriaCargo(cargoDTO);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemoveCargo(int idCargo)
        {
            try
            {
                return repositorioCargo.RemoveCargo(idCargo);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public CargoDTO AtualizaCargo(CargoDTO cargoDTO)
        {
            try
            {
                return repositorioCargo.AtualizaCargo(cargoDTO);
            }
            catch (Exception ex)
            {
                return new CargoDTO();
            }
        }
    }
}
