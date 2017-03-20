using ValSystem.Model;

namespace ValSystem.Controller
{
    public class AppController
    {
        #region Old
        //public AppController() : base( "DefaultConnection" )
        //{
        //    Configuration.LazyLoadingEnabled = false;
        //    Configuration.ProxyCreationEnabled = false;
        //}

        //public virtual DbSet<Perfil> Perfis { get; set; }
        //public virtual DbSet<Usuario> Usuarios { get; set; }
        //public virtual DbSet<Modulo> Modulos { get; set; }
        //public virtual DbSet<ModuloItem> ModulosItens { get; set; }
        //public virtual DbSet<Rotina> Rotinas { get; set; }
        //public virtual DbSet<RotinaItem> RotinasItens { get; set; }

        //protected override void OnModelCreating( DbModelBuilder modelBuilder )
        //{
        //    //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //    //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        //    //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

        //    //modelBuilder.Properties().Where( p => p.Name == p.ReflectedType.Name + "Id" ).Configure( p => p.IsKey() );
        //    //modelBuilder.Properties<string>().Configure( p => p.HasColumnType( "varchar" ) );
        //    //modelBuilder.Properties<string>().Configure( p => p.HasMaxLength( 100 ) );

        //    //modelBuilder.Entity<Perfil>();
        //    //modelBuilder.Entity<Usuario>();
        //    //modelBuilder.Entity<Modulo>();
        //    //modelBuilder.Entity<ModuloItem>();
        //    //modelBuilder.Entity<Rotina>();
        //    //modelBuilder.Entity<RotinaItem>();

        //    //ModelConfiguration.Configure( modelBuilder );
        //    //Database.SetInitializer( modelBuilder );
        //} 
        #endregion

        public AppController()
        {

        }

    }
}
