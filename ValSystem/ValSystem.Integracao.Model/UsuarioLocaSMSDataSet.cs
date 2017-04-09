namespace ValSystem.Integracao.Model
{


    partial class UsuarioLocaSMSDataSet
    {
    }
}

namespace ValSystem.Integracao.Model.UsuarioLocaSMSDataSetTableAdapters
{


    public partial class UsuariosLocaSMSTableAdapter
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
