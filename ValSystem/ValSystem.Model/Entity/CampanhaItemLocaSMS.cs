using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValSystem.SQLite.Public.Attributes;

namespace ValSystem.Model.Entity
{
    public class CampanhaItemLocaSMS
    {

        [Key]
        [Column( Order = 1 )]
        [Index( "IX_CampanhaItemLocaSMS_Main", IsUnique = true, Order = 1 )]
        public decimal IdCampanhaLocaSMS { get; set; }
        [Key]
        [Column( Order = 2 )]
        [Index( "IX_CampanhaItemLocaSMS_Main", IsUnique = true, Order = 2 )]
        public decimal IdContatoLocaSMS { get; set; }
        [MaxLength( 1 )]
        public string Destino { get; set; }
        [MaxLength( 20 )]
        public string Operadora { get; set; }
        [MaxLength( 1 )]
        public string Preso { get; set; }
        [MaxLength( 155 )]
        public string Resposta { get; set; }
        [Required]
        public DateTime Data { get; set; }
        public DateTime DataEnvio { get; set; }
        [MaxLength( 200 )]
        public string retornoLocaSMS { get; set; }
        [MaxLength( 50 ), Required]
        public string CodigoRef { get; set; }
        [MaxLength( 50 )]
        public string CodigoLocaSMS { get; set; }
        [MaxLength( 30 )]
        public string Parametro1 { get; set; }
        [MaxLength( 30 )]
        public string Parametro2 { get; set; }
        [MaxLength( 30 )]
        public string Parametro3 { get; set; }
        [MaxLength( 30 )]
        public string Parametro4 { get; set; }
        [MaxLength( 30 )]
        public string Parametro5 { get; set; }
    }
}
