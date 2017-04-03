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
    public class UsuarioEmpresa
    {
        //[Autoincrement]
        //public int Id { get; set; }
        [Key]
        [Column( Order = 1 )]
        [Index( "IX_UsuarioEmpresa_Main", Order = 2, IsUnique = true )]
        public int IdUsuario { get; set; }
        [Key]
        [Column( Order = 2 )]
        [Index( "IX_UsuarioEmpresa_Main", Order = 1, IsUnique = true )]
        public int IdEmpresa { get; set; }
    }
}
