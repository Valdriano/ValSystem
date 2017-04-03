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
    public class Empresa
    {

        public Empresa()
        {
            UsuariosEmpresas = new HashSet<UsuarioEmpresa>();
        }

        [Autoincrement]
        public int Id { get; set; }
        [MaxLength( 4 ), Required]
        public string Codigo { get; set; }
        [MaxLength( 60 ), Required]
        public string RazaoSocial { get; set; }
        [MaxLength( 60 ), Required]
        public string Fantasia { get; set; }
        [MaxLength( 60 ), Required]
        public string Endereco { get; set; }
        [MaxLength( 10 )]
        public string Numero { get; set; }
        [MaxLength( 30 )]
        public string Complemento { get; set; }
        [MaxLength( 9 )]
        public string Cep { get; set; }
        [MaxLength( 40 )]
        public string Bairro { get; set; }
        [MaxLength( 40 )]
        public string Cidade { get; set; }
        [MaxLength( 40 )]
        public string Estado { get; set; }
        [MaxLength( 40 )]
        public string Pais { get; set; }
        [MaxLength( 2 )]
        public string UF { get; set; }
        [MaxLength( 17 )]
        public string CNPJ { get; set; }
        [MaxLength( 50 )]
        public string Telefones { get; set; }
        [MaxLength( 60 )]
        public string Email { get; set; }
        [MaxLength( 60 )]
        public string WebSite { get; set; }
        [Required]
        public DateTime DataCadastro { get; set; }
        [Required]
        public int IdUsuarioCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? IdUsuarioAlteracao { get; set; }

        [ForeignKey( "IdEmpresa" )]
        public virtual HashSet<UsuarioEmpresa> UsuariosEmpresas { get; set; }
    }
}
