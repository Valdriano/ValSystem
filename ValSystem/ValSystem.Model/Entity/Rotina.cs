using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ValSystem.Model
{
    public class Rotina
    {
        public Rotina()
        {
            //RotinasItens = new HashSet<RotinaItem>();
        }

        [Key, DatabaseGenerated( DatabaseGeneratedOption.Identity )]
        public int Id { get; set; }
        [Required]
        public int IdRotina { get; set; }
        [Required]
        public int IdModulo { get; set; }
        [Required]
        public int IdModuloItem { get; set; }
        [MaxLength( 30 ), Required]
        public string Descricao { get; set; }
        [MaxLength( 60 ), Required]
        public string NameSpace { get; set; }
        [MaxLength( 60 ), Required]
        public string NameAssembly { get; set; }

        //public virtual ICollection<RotinaItem> RotinasItens { get; set; }
    }
}
