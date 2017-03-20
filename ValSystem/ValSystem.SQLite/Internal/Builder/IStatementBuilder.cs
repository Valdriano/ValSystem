using ValSystem.SQLite.Internal.Statement;

namespace ValSystem.SQLite.Internal.Builder
{
    internal interface IStatementBuilder<out TStatement>
        where TStatement : IStatement
    {
        TStatement BuildStatement();
    }
}
