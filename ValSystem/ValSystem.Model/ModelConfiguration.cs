using System.Data.Entity;
using ValSystem.Model.Entity;

namespace ValSystem.Model
{
    class ModelConfiguration
    {
        public static void Configure( DbModelBuilder modelBuilder )
        {
            #region Tabelas do Sistema

            ConfigureHistoricoDBEntity( modelBuilder );

            #endregion


            #region Modulo 1

            ConfigurePerfilEntity( modelBuilder );
            ConfigureUsuarioEntity( modelBuilder );
            ConfigureModuloEntity( modelBuilder );
            ConfigureModuloItemEntity( modelBuilder );
            ConfigureRotinaEntity( modelBuilder );
            ConfigureRotinaItemEntity( modelBuilder );
            ConfigurePermissaoEntity( modelBuilder );
            ConfigurePermissaoItemEntity( modelBuilder );
            ConfigureEmpresaEntity( modelBuilder );
            ConfigureUsuarioEmpresaEntity( modelBuilder );
            ConfigurePaisEntity( modelBuilder );
            ConfigureUFEntity( modelBuilder );
            ConfigureEstadosEntity( modelBuilder );

            #endregion


            #region Modulo 10

            ConfigureUsuarioLocaSMSEntity( modelBuilder );
            ConfigureContatoLocaSMSEntity( modelBuilder );
            ConfigureCampanhaLocaSMSEntity( modelBuilder );
            ConfigureCampanhaItemLocaSMSEntity( modelBuilder );

            #endregion
        }

        #region Tabelas do Sistema

        private static void ConfigureHistoricoDBEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<CustomHistory>().ToTable( "Base.HistoricoDB" );
        }

        #endregion

        #region Modulo 1

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

        private static void ConfigurePermissaoEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Permissao>().ToTable( "Base.Permissao" );
        }

        private static void ConfigurePermissaoItemEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<PermissaoItem>().ToTable( "Base.PermissaoItem" );
        }

        private static void ConfigureEmpresaEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Empresa>().ToTable( "Base.Empresas" );
        }

        private static void ConfigureUsuarioEmpresaEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<UsuarioEmpresa>().ToTable( "Base.UsuarioEmpresas" );
        }

        private static void ConfigurePaisEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Pais>().ToTable( "Base.Pais" );
        }

        private static void ConfigureUFEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<UF>().ToTable( "Base.UF" );
        }

        private static void ConfigureEstadosEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Estados>().ToTable( "Base.Estados" );
        }

        #endregion

        #region Modulo 10

        private static void ConfigureUsuarioLocaSMSEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<UsuarioLocaSMS>().ToTable( "UsuariosLocaSMS" );
        }

        private static void ConfigureContatoLocaSMSEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<ContatoLocaSMS>().ToTable( "Base.ContatosLocaSMS" );
        }

        private static void ConfigureCampanhaLocaSMSEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<CampanhaLocaSMS>().ToTable( "Base.CampanhaLocaSMS" );
        }

        private static void ConfigureCampanhaItemLocaSMSEntity( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<CampanhaItemLocaSMS>().ToTable( "Base.CampanhaItemLocaSMS" );
        }

        #endregion
    }
}
