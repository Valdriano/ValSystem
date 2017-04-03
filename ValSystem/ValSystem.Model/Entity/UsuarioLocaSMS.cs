using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValSystem.SQLite.Public.Attributes;

namespace ValSystem.Model.Entity
{
    public class UsuarioLocaSMS
    {
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
    }
}
