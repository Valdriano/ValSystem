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
    public class ContatoLocaSMS
    {
        public ContatoLocaSMS()
        {
            CampanhaItensLocaSMS = new HashSet<CampanhaItemLocaSMS>();
        }

        [Autoincrement]
        public int Id { get; set; }
        [Required, MaxLength( 60 )]
        public string Nome { get; set; }
        [MaxLength( 40 )]
        public string Bairro { get; set; }
        [MaxLength( 60 )]
        public string Endereco { get; set; }
        [MaxLength( 9 )]
        public string Cep { get; set; }
        [MaxLength( 40 )]
        public string Cidade { get; set; }
        [MaxLength( 40 )]
        public string Estado { get; set; }
        [MaxLength( 2 )]
        public string UF { get; set; }
        [MaxLength( 60 )]
        public string Email { get; set; }
        public short? DDD { get; set; }
        public int? Telefone { get; set; }
        public int? Celular1 { get; set; }
        public int? Celular2 { get; set; }
        public int? Celular3 { get; set; }
        public int? Celular4 { get; set; }
        public int? QtdEnvioCel1 { get; set; }
        public int? QtdEnvioCel2 { get; set; }
        public int? QtdEnvioCel3 { get; set; }
        public int? QtdEnvioCel4 { get; set; }
        [MaxLength( 200 )]
        public string retornoCel1 { get; set; }
        [MaxLength( 200 )]
        public string retornoCel2 { get; set; }
        [MaxLength( 200 )]
        public string retornoCel3 { get; set; }
        [MaxLength( 200 )]
        public string retornoCel4 { get; set; }

        [ForeignKey( "IdContatoLocaSMS" )]
        public virtual HashSet<CampanhaItemLocaSMS> CampanhaItensLocaSMS { get; set; }
    }
}
