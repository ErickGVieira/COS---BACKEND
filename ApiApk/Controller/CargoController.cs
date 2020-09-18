using Cos.Dominio.Modelos;
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
            return new CargoDTO();
        }

        [HttpGet]
        [ActionName("obtemTodos")]
        public List<CargoDTO> ObterTodos()
        {
            return new List<CargoDTO>();
        }

        [HttpPost]
        [ActionName("cria")]
        public bool Cria()
        {
            return true;
        }

        [HttpPut]
        [ActionName("atualiza")]
        public CargoDTO Atualiza()
        {
            return new CargoDTO();
        }

        [HttpDelete]
        [ActionName("remove")]
        public bool Remove()
        {
            return true;
        }
    }
}
