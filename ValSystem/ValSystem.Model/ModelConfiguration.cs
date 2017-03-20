using System.Data.Entity;
using ValSystem.Model.Entity;

namespace ValSystem.Model
{
    class ModelConfiguration
    {
        public static void Configure( DbModelBuilder modelBuilder )
        {
            ConfigureHistoricoDBEntity( modelBuilder );
            ConfigurePerfilEntity( modelBuilder );
            ConfigureUsuarioEntity( modelBuilder );
            ConfigureModuloEntity( modelBuilder );
            ConfigureModuloItemEntity( modelBuilder );
            ConfigureRotinaEntity( modelBuilder );
            ConfigureRotinaItemEntity( modelBuilder );
        }

        private static void ConfigureHistoricoDBEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<CustomHistory>().ToTable( "Base.HistoricoDB" );
        }

        private static void ConfigurePerfilEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Perfil>().ToTable( "Base.Perfis" );
            //.HasRequired( r => r.Usuarios )
            //.WithMany()
            //.WillCascadeOnDelete( false );
        }

        private static void ConfigureUsuarioEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Usuario>().ToTable( "Base.Usuarios" );
        }

        private static void ConfigureModuloEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Modulo>().ToTable( "Base.Modulos" );
            //.HasRequired( r => r.ModulosItens )
            //.WithMany()
            //.WillCascadeOnDelete( false );
        }

        private static void ConfigureModuloItemEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<ModuloItem>().ToTable( "Base.ModuloItens" );
        }

        private static void ConfigureRotinaEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Rotina>().ToTable( "Base.Rotinas" );
            //.HasRequired( r => r.RotinasItens )
            //.WithMany()
            //.WillCascadeOnDelete( false );
        }

        private static void ConfigureRotinaItemEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<RotinaItem>().ToTable( "Base.RotinaItens" );
        }
    }
}
