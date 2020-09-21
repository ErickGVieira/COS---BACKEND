using Cos.Dominio.Modelos;
using Sanegeo.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiApk.Controller
{
    public class CargoController : ApiController
    {
        [HttpGet]
        [ActionName("obtem")]
        public CargoDTO Obter(int idCargo)
        {
            return new ServicoCargo().ObtemCargo(idCargo);
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<CargoDTO> ObterTodos()
        {
            return new ServicoCargo().ObtemCargos();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria(CargoDTO cargoDTO)
        {
            return new ServicoCargo().CriaCargo(cargoDTO);
        }

        [HttpPut]
        [ActionName("atualiza")]
        public CargoDTO Atualiza(CargoDTO cargoDTO)
        {
            return new ServicoCargo().AtualizaCargo(cargoDTO);
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove(int idCargo)
        {
            return new ServicoCargo().RemoveCargo(idCargo);
        }
    }
}
