

using System.ComponentModel.DataAnnotations;

namespace ValSystem.Model
{
    public class RotinaItem
    {
        public RotinaItem()
        {

        }

        public int IdRotinaItem { get; set; }
        public int IdRotina { get; set; }
        [MaxLength( 20 ), Required]
        public string Descricao { get; set; }
    }
}
