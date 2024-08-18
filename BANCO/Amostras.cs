using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOLYID.BANCO
{
    public class amostras:tiposdeamostras
    {
        public int id { get; set; }
        public int fichadecampoid { get; set; }
        public int tiposdeamostrasid { get; set; }
        public string nomeamostras { get; set; }
        public string local { get; set; }

        public fichadecampo fichadecampo { get; set; } // Navigation Property
        public tiposdeamostras tiposdeamostras { get; set; } // Navigation Property
    }
}
