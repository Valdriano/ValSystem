using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ValSystem.Model
{
    public class Modulo
    {
        public Modulo()
        {
            ModulosItens = new HashSet<ModuloItem>();
        }

        [Key, DatabaseGenerated( DatabaseGeneratedOption.Identity )]
        public int Id { get; set; }
        [Required]
        public int IdModulo { get; set; }
        [MaxLength( 30 ), Required]
        public string Descricao { get; set; }

        public virtual ICollection<ModuloItem> ModulosItens { get; set; }

    }
}
