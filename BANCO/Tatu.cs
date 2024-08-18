using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOLYID.BANCO
{
    
        public class tatu
        {
   
        public static string? Text { get; internal set; }
        [Key]
        [Column("numerodeidentificacao")]
        public int numerodeidentificacao { get; set; }
        [Column("identificacaodoanimal")]
        public string identificacaoaoanimal { get; set; }
        [Column("peso")]
        public decimal peso { get; set; }
        [Column("observacoes")]
        public string observacoes { get; set; }
      
    }
    
}
