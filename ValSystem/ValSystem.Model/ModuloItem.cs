using System.ComponentModel.DataAnnotations;

namespace ValSystem.Model
{
    public class ModuloItem
    {
        public int IdModuloItem { get; set; }
        public int IdModulo { get; set; }
        [MaxLength( 30 ), Required]
        public string Descricao { get; set; }
    }
}
