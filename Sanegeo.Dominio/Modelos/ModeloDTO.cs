using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Modelos
{
    public class ModeloDTO
    {
        public int ID { get; set; }
        public string CODE { get; set; }
        public string ALTERNATIVE_CODE { get; set; }
        public decimal MAX_DEPARTURE_WEIGHT { get; set; }
        public decimal MAX_LANDING_WEIGHT { get; set; }
    }
}
