using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValSystem.Connection;
using ValSystem.Integracao.Model;
using ValSystem.Integracao.Model.UsuarioLocaSMSDataSetTableAdapters;

namespace ValSystem.Integracao.Controller
{
    public class UsuarioLocaSMSController
    {
        public static UsuarioLocaSMSDataSet.UsuariosLocaSMSDataTable GetUsuariosLocaSMS()
        {
            UsuariosLocaSMSTableAdapter da = new UsuariosLocaSMSTableAdapter();

            UsuarioLocaSMSDataSet ds = new UsuarioLocaSMSDataSet();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;
                da.Fill( ds.UsuariosLocaSMS );
            }

            return ds.UsuariosLocaSMS;
        }

        public static UsuarioLocaSMSDataSet.UsuariosLocaSMSDataTable GetUsuarioLocaSMS( int Id )
        {
            UsuariosLocaSMSTableAdapter da = new UsuariosLocaSMSTableAdapter();

            UsuarioLocaSMSDataSet ds = new UsuarioLocaSMSDataSet();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;
                da.FillBy( ds.UsuariosLocaSMS, Id );
            }

            return ds.UsuariosLocaSMS;
        }

        public static string SetUpdate( UsuarioLocaSMSDataSet ds )
        {
            UsuariosLocaSMSTableAdapter da = new UsuariosLocaSMSTableAdapter();

            SQLiteTransaction trans = null;

            try
            {
                using ( SQLiteConnection conn = Connections.ConnSQLite() )
                {
                    trans = conn.BeginTransaction();

                    da.Connection = conn;
                    da.CommandTimeout = 0;
                    da.Transactions = trans;
                    da.Update( ds.UsuariosLocaSMS );

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
