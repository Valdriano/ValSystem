using System.Collections.Generic;

namespace ValSystem.SQLite.Internal.Statement.ColumnConstraint
{
    interface IColumnConstraintCollection : ICollection<IColumnConstraint>, IColumnConstraint
    {
    }
}
