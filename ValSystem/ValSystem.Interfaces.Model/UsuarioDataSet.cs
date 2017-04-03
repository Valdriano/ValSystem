namespace ValSystem.Interfaces.Model
{


    partial class UsuarioDataSet
    {
    }
}

namespace ValSystem.Interfaces.Model.UsuarioDataSetTableAdapters
{
    partial class ConsultaTableAdapter
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
    }

    partial class PerfisTableAdapter
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
    }

    public partial class UsuariosTableAdapter
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
