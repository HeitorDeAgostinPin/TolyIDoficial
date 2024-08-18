using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOLYID.BANCO
{
    public class equipe:usuario
    {
        public int id { get; set; }
        public int idequiperesponsavel { get; set; }
        public string instituicao { get; set; }
        public usuario usuarioresponsavel { get; set; } 
    }
}
