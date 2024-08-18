using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOLYID.BANCO
{
    public class fichaanestesica:fichadecampo
    {
        public int id { get; set; }
        public int fichadecampoid { get; set; }
        public decimal dose { get; set; }
        public TimeSpan tempodeanestesia { get; set; }
        public string tipoanestesia { get; set; }
        public string viadeadministracao { get; set; }
        public TimeSpan aplicacao { get; set; }
        public TimeSpan inducao { get; set; }
        public TimeSpan retorno { get; set; }
        public string observacoes { get; set; }
        public decimal temperatura { get; set; }
        public string parametrosfisiologicos { get; set; }

        public fichadecampo fichadecampo { get; set; } // Navigation Property
    }
}
