using System.Collections.Generic;

namespace ValSystem.SQLite.Internal.Statement
{
    public interface IStatementCollection : IStatement, ICollection<IStatement>
    {
    }
}
