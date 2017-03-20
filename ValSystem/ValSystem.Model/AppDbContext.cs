using System.Data.Common;
using System.Data.Entity;

namespace ValSystem.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext( string nameOrConnectionString ) : base( nameOrConnectionString )
        {
            Configure();
        }

        public AppDbContext( DbConnection connection, bool contextOwnsConnection ) : base( connection, contextOwnsConnection )
        {
            Configure();
        }

        private void Configure()
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating( DbModelBuilder modelBuilder )
        {
            //base.OnModelCreating( modelBuilder );

            ModelConfiguration.Configure( modelBuilder );
            var initializer = new AppDbInicializar( modelBuilder );
            Database.SetInitializer( initializer );
        }
    }
}
