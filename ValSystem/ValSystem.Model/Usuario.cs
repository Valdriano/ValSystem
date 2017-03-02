using System.ComponentModel.DataAnnotations;

namespace ValSystem.Model
{
    public class Usuario
    {
        public Usuario()
        {
            //Perfis = new HashSet<Perfil>();
        }

        public int IdUsuario { get; set; }
        [MaxLength( 30 ), Required]
        public string Descricao { get; set; }
        [MaxLength( 30 ), Required]
        public string Senha { get; set; }
        public bool Bloqueado { get; set; }
        public int IdPerfil { get; set; }
        //public byte[] RowVersion { get; set; }

        //public virtual ICollection<Perfil> Perfis { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
