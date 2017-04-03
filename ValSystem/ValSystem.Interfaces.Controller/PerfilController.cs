using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValSystem.Connection;
using ValSystem.Interfaces.Model;
using ValSystem.Interfaces.Model.PerfilDataSetTableAdapters;
using ValSystem.Model;

namespace ValSystem.Interfaces.Controller
{
    public class PerfilController
    {
        public static PerfilDataSet.PerfisDataTable GetPerfil( int Id = -2 )
        {
            PerfisTableAdapter da = new PerfisTableAdapter();

            PerfilDataSet ds = new PerfilDataSet();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;

                if ( Id == -2 )
                {
                    da.Fill( ds.Perfis );
                }
                else
                {
                    da.FillById( ds.Perfis, Id );
                }
            }

            return ds.Perfis;
        }

        public static string SetUpdate( PerfilDataSet ds )
        {
            PerfisTableAdapter da = new PerfisTableAdapter();

            SQLiteTransaction trans = null;

            try
            {
                using ( SQLiteConnection conn = Connections.ConnSQLite() )
                {
                    trans = conn.BeginTransaction();

                    da.Connection = conn;
                    da.CommandTimeout = 0;
                    da.Transactions = trans;
                    da.Update( ds.Perfis );

                    trans.Commit();
                }

                return "";
            }
            catch ( Exception ex )
            {
                if ( trans != null )
                    trans.Rollback();

                return ex.Message;
            }
        }
    }
}
