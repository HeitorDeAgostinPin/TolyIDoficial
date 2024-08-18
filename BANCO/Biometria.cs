using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOLYID.BANCO
{
    public class biometria:fichadecampo
    {
        public byte[] foto;
        public int id { get; set; }
        public int fichadecampoid { get; set; }
        public decimal comprimentototal { get; set; }
        public decimal comprimentodacabeça { get; set; }
        public decimal larguradacabeça { get; set; }
        public decimal comprimentodoescudoencefalico { get; set; }
        public string padraodorscudoencefalico { get; set; }
        public decimal comprimentodacauda { get; set; }
        public decimal larguracaudal { get; set; }
        public decimal comprimentodopelo { get; set; }
        public decimal comprimentodaunha { get; set; }
        public decimal comprimentodaorelha { get; set; }
        public decimal comprimentodoescudopelvico { get; set; }
        public decimal semicircunferenciaescudoescapular { get; set; }
        public decimal semicircunferenciaescudopelvico { get; set; }
        public decimal largurasegundacinta { get; set; }
        public decimal comprimentodoclitoris { get; set; }
        public decimal comprimentodopenis { get; set; }
        public decimal largurainterorbital { get; set; }
        public decimal largurainterlacrimal { get; set; }
        public decimal largurabasedopenis { get; set; }
        public int numeroDecintas { get; set; }
        public string observacoes { get; set; }

        public fichadecampo fichadecampo { get; set; } // Navigation Property
    }

}
