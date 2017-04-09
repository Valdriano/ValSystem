namespace ValSystem.Integracao.Model
{


    partial class CampanhaLocaSMSDataSet
    {
    }
}

namespace ValSystem.Integracao.Model.CampanhaLocaSMSDataSetTableAdapters
{
    partial class Seq_CampanhaLocaSMSTableAdapter
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

    partial class UsuariosLocaSMSTableAdapter
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

    partial class ConsultaItemTableAdapter
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

    partial class ContatosLocaSMSTableAdapter
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

    partial class CampanhaItemLocaSMSTableAdapter
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

    public partial class CampanhaLocaSMSTableAdapter
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
