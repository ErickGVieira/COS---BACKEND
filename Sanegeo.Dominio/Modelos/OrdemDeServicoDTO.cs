using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Modelos
{
    public class OrdemDeServicoDTO
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public int idServicoSolicitado { get; set; }
        public int idServicoExecutado { get; set; }
        public int idStatus { get; set; }
        public System.DateTime dataInicio { get; set; }
        public Nullable<System.DateTime> dataFim { get; set; }
        public int idSolicitante { get; set; }
        public Nullable<int> idExecutor { get; set; }

        public ClienteDTO Cliente { get; set; }
        public ServicoDTO Servico { get; set; }
        public UsuarioDTO Usuario { get; set; }
        public ServicoDTO Servico1 { get; set; }
        public UsuarioDTO Usuario1 { get; set; }
        public StatusDTO Status { get; set; }
    }
}
