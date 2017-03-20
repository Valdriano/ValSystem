using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ValSystem.SQLite.Public
{
    public interface IDatabaseCreator
    {
        void Create( Database db, DbModel model );
    }
}