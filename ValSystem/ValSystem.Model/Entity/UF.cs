using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValSystem.Model.Entity
{
    public class UF
    {
        public UF()
        {
            Estados = new HashSet<Estados>();
        }

        [Key]
        [Column( Order = 1 )]
        [Index( "IX_UF_Main", IsUnique = true, Order = 1 )]
        [MaxLength( 40 ), Required]
        public string Pais { get; set; }
        [Key]
        [Column( Order = 2 )]
        [Index( "IX_UF_Main", IsUnique = true, Order = 2 )]
        [MaxLength( 2 ), Required]
        public string Descricao { get; set; }

        //[ForeignKey( "UF" )]
        public virtual ICollection<Estados> Estados { get; set; }
    }
}
