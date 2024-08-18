using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOLYID.BANCO
{
    public class parametrosfisiologicos:fichaanestesica
    {
        public int id { get; set; }
        public int fichaanestesicaid { get; set; }
        public int fc { get; set; }
        public int fr { get; set; }
        public decimal sp02 { get; set; }
        public decimal temperatura { get; set; }
        public string biximetria { get; set; }

        public fichaanestesica fichaanestesica { get; set; } // Navigation Property
    }
}
