using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos.Dominio.Modelos
{
    public class AeronaveDTO
    {
        public int ID { get; set; }
        public string PREFIX { get; set; }
        public decimal MAX_DEPARTURE_WEIGHT { get; set; }
        public decimal MAX_LANDING_WEIGHT { get; set; }
        public bool ACTIVE { get; set; }
        public string AIRCRAFT_MODEL { get; set; }
        public int PASSENGERS_COUNT_AIRCRAFT { get; set; }
    }
}
