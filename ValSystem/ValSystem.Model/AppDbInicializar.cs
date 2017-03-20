using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using ValSystem.Model.Entity;
using ValSystem.SQLite.Public.DbInitializers;

namespace ValSystem.Model
{
    public class AppDbInicializar : SqliteDropCreateDatabaseWhenModelChanges<AppDbContext>
    {
        public AppDbInicializar( DbModelBuilder modelBuilder ) : base( modelBuilder, typeof( CustomHistory ) )
        {
        }

        protected override void Seed( AppDbContext context )
        {
            //base.Seed( context );
            // Here you can seed your core data if you have any.           

        }
    }

}
