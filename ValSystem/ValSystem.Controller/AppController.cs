using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ValSystem.Model;

namespace ValSystem.Controller
{
    public class AppController : DbContext
    {
        public AppController() : base( "DefaultConnection" )
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Perfil> Perfis { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Modulo> Modulos { get; set; }
        public virtual DbSet<ModuloItem> ModulosItens { get; set; }
        public virtual DbSet<Rotina> Rotinas { get; set; }
        public virtual DbSet<RotinaItem> RotinasItens { get; set; }

        protected override void OnModelCreating( DbModelBuilder modelBuilder )
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //modelBuilder.Properties().Where( p => p.Name == p.ReflectedType.Name + "Id" ).Configure( p => p.IsKey() );
            //modelBuilder.Properties<string>().Configure( p => p.HasColumnType( "varchar" ) );
            //modelBuilder.Properties<string>().Configure( p => p.HasMaxLength( 100 ) );

            modelBuilder.Entity<Perfil>().HasKey( k => k.IdPerfil );
            modelBuilder.Entity<Usuario>().HasKey( k => k.IdUsuario );
            modelBuilder.Entity<Modulo>().HasKey( k => k.IdModulo );
            modelBuilder.Entity<ModuloItem>().HasKey( k => k.IdModuloItem );
            modelBuilder.Entity<Rotina>().HasKey( k => k.IdRotina );
            modelBuilder.Entity<RotinaItem>().HasKey( k => k.IdRotinaItem );
        }

    }
}
