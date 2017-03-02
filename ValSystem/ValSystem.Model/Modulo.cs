using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ValSystem.Model
{
    public class Modulo
    {
        public Modulo()
        {
            ModulosItens = new HashSet<ModuloItem>();
        }

        public int IdModulo { get; set; }
        [MaxLength( 30 ), Required]
        public string Descricao { get; set; }

        public virtual ICollection<ModuloItem> ModulosItens { get; set; }

    }
}
