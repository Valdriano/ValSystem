namespace ValSystem.Integracao.Model
{


    partial class ContatoLocaSMSDataSet
    {
    }
}

namespace ValSystem.Integracao.Model.ContatoLocaSMSDataSetTableAdapters
{
    partial class Seq_ContatoLocaSMSTableAdapter
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

    public partial class ContatosLocaSMSTableAdapter
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
