using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Modelos
{
    public class UsuarioDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string senha { get; set; }
        public int idCargo { get; set; }

        public virtual CargoDTO Cargo { get; set; }
    }
}
