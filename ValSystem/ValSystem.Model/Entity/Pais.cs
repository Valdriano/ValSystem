using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValSystem.Model.Entity
{
    public class Pais
    {
        public Pais()
        {
            UFs = new HashSet<UF>();
        }

        [Key]
        [Column( Order = 1 )]
        [Index( "IX_Pais_Main", IsUnique = true, Order = 1 )]
        [MaxLength( 40 )]
        public string Descricao { get; set; }

        [ForeignKey( "Pais" )]
        public virtual HashSet<UF> UFs { get; set; }
    }
}
