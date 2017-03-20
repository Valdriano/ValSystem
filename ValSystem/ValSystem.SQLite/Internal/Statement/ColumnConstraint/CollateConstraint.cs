using System.Text;
using ValSystem.SQLite.Public.Attributes;

namespace ValSystem.SQLite.Internal.Statement.ColumnConstraint
{
    internal class CollateConstraint : IColumnConstraint
    {
        private const string Template = "COLLATE {collation-name}";

        public CollationFunction CollationFunction { get; set; }

        public string CreateStatement()
        {
            if ( CollationFunction == CollationFunction.None )
            {
                return string.Empty;
            }

            var sb = new StringBuilder( Template );

            sb.Replace( "{collation-name}", CollationFunction.ToString().ToUpperInvariant() );

            return sb.ToString().Trim();
        }
    }
}
