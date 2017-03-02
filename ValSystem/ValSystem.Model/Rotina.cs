
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ValSystem.Model
{
    public class Rotina
    {
        public Rotina()
        {
            RotinasItens = new HashSet<RotinaItem>();
        }

        public int IdRotina { get; set; }
        public int IdModulo { get; set; }
        public int IdModuloItem { get; set; }
        [MaxLength( 30 ), Required]
        public string Descricao { get; set; }
        [MaxLength( 60 ), Required]
        public string NameSpace { get; set; }
        [MaxLength( 60 ), Required]
        public string NameAssembly { get; set; }

        public virtual ICollection<RotinaItem> RotinasItens { get; set; }
    }
}
