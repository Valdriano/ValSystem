using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ValSystem.Model
{
    public class Perfil
    {
        public Perfil()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdPerfil { get; set; }
        [MaxLength( 30 ), Required]
        public string Descricao { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
