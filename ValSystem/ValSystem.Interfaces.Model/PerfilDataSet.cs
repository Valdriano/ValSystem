namespace ValSystem.Interfaces.Model
{


    partial class PerfilDataSet
    {
    }
}

namespace ValSystem.Interfaces.Model.PerfilDataSetTableAdapters
{


    public partial class PerfisTableAdapter
    {

        public int CommandTimeout
        {
            set
            {
                for ( int i = 0; i < this.CommandCollection.Length; i++ )
                {
                    this.CommandCollection[ i ].CommandTimeout = value;
                }
            }
        }

        public System.Data.SQLite.SQLiteTransaction Transactions
        {
            set { this.Transaction = value; }
        }
    }
}
