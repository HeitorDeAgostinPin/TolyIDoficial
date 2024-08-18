using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOLYID.BANCO
{
    
    public class fichadecampo:tatu
    {
        public int Id { get; set; }
        public string numerodomicrochip { get; set; }
        public DateTime datadacaptura { get; set; }
        public TimeSpan horariodacaptura { get; set; }
        public string localdecaptura { get; set; }
        public int identificacaodoanimal { get; set; }
        public int idequiperesponsavel { get; set; }
        public string instituicaoresponsavel { get; set; }

        public tatu tatu { get; set; } // Navigation Property
        public equipe equiperesponsavel { get; set; } // Navigation Property
    }
}
