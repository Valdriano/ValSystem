using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ValSystem.Model
{
    public class ModuloItem
    {
        public ModuloItem()
        {
            //Modulos = new HashSet<Modulo>();
        }

        [Key, DatabaseGenerated( DatabaseGeneratedOption.Identity )]
        public int Id { get; set; }
        [Required]
        public int IdModuloItem { get; set; }
        //[ForeignKey( "Modulo" )]
        public int IdModulo { get; set; }
        [MaxLength( 30 ), Required]
        public string Descricao { get; set; }
        //[ForeignKey( "IdModulo" )]
        //public virtual ICollection<Modulo> Modulos { get; set; }
    }
}
