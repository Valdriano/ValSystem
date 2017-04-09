using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValSystem.SQLite.Public.Attributes;

namespace ValSystem.Model.Entity
{
    public class UsuarioLocaSMS
    {
        public UsuarioLocaSMS()
        {
            CampanhaLocaSMS = new HashSet<CampanhaLocaSMS>();
        }

        [Autoincrement]
        public int Id { get; set; }
        [Required, MaxLength( 40 )]
        public string Descricao { get; set; }
        [Required, MaxLength( 20 )]
        public string Login { get; set; }
        [Required, MaxLength( 20 )]
        public string Senha { get; set; }
        public decimal Saldo { get; set; }
        [Required]
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool Bloqueado { get; set; }

        [ForeignKey( "IdUsuarioLocaSMS" )]
        public virtual ICollection<CampanhaLocaSMS> CampanhaLocaSMS { get; set; }
    }
}
