using System.ComponentModel.DataAnnotations;

namespace ValSystem.Model
{
    public class RotinaItem
    {
        public RotinaItem()
        {
            //Rotinas = new HashSet<Rotina>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public int IdRotinaItem { get; set; }
        [Required]
        public int IdRotina { get; set; }
        [MaxLength( 20 ), Required]
        public string Descricao { get; set; }
        [Required]
        public int Item { get; set; }

        //public virtual ICollection<Rotina> Rotinas { get; set; }
    }
}
