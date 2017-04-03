using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ValSystem.SQLite.Public.Attributes;

namespace ValSystem.Model
{
    public class Usuario
    {
        public Usuario()
        {
            //Perfis = new HashSet<Perfil>();
        }

        //[Key, DatabaseGenerated( DatabaseGeneratedOption.Identity )]
        [Autoincrement]
        public int Id { get; set; }
        [MaxLength( 30 ), Required]
        public string Descricao { get; set; }
        [MaxLength( 30 ), Required]
        public string Senha { get; set; }
        [Required]
        public bool Bloqueado { get; set; }
        [Required]
        public int IdPerfil { get; set; }


        //public virtual ICollection<Perfil> Perfis { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
