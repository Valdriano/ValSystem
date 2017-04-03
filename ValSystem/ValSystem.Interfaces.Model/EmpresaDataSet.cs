namespace ValSystem.Interfaces.Model
{


    partial class EmpresaDataSet
    {
    }
}

namespace ValSystem.Interfaces.Model.EmpresaDataSetTableAdapters
{


    public partial class EmpresasTableAdapter
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
