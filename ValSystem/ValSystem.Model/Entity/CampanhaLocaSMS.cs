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
    public class CampanhaLocaSMS
    {
        public CampanhaLocaSMS()
        {
            //UsuariosLocaSMS = new HashSet<UsuarioLocaSMS>();
            CampanhaItensLocaSMS = new HashSet<CampanhaItemLocaSMS>();
        }

        [Key]
        public decimal Id { get; set; }
        [Required]
        public int IdUsuarioLocaSMS { get; set; }
        [Required, MaxLength( 50 )]
        public string Descricao { get; set; }
        [Required, MaxLength( 155 )]
        public string Mensagem { get; set; }
        [Required]
        public DateTime Data { get; set; }
        public bool AgendaSMS { get; set; }
        public DateTime? DataHoraAgendaSMS { get; set; }
        public DateTime? DataConsulta { get; set; }
        public DateTime? DataUltConsulta { get; set; }
        [MaxLength( 255 )]
        public string retornoLocaSMS { get; set; }
        [MaxLength( 100 )]
        public string CodigoRetorno { get; set; }

        //public virtual HashSet<UsuarioLocaSMS> UsuariosLocaSMS { get; set; }
        [ForeignKey( "IdCampanhaLocaSMS" )]
        public virtual ICollection<CampanhaItemLocaSMS> CampanhaItensLocaSMS { get; set; }
    }
}
