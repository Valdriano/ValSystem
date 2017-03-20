using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ValSystem.Model
{
    public class Perfil
    {
        public Perfil()
        {
            Usuarios = new HashSet<Usuario>();
        }

        [Key, DatabaseGenerated( DatabaseGeneratedOption.Identity )]
        public int Id { get; set; }
        [MaxLength( 30 ), Required]
        public string Descricao { get; set; }

        [ForeignKey( "IdPerfil" )]
        public virtual ICollection<Usuario> Usuarios { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
