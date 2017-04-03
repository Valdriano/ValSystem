using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValSystem.Connection;
using ValSystem.Interfaces.Model;
using ValSystem.Interfaces.Model.EmpresaDataSetTableAdapters;

namespace ValSystem.Interfaces.Controller
{
    public class EmpresaController
    {
        public static EmpresaDataSet.EmpresasDataTable GetEmpresas()
        {
            EmpresasTableAdapter da = new EmpresasTableAdapter();

            EmpresaDataSet ds = new EmpresaDataSet();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;
                da.Fill( ds.Empresas );
            }

            return ds.Empresas;
        }

        public static EmpresaDataSet.EmpresasDataTable GetEmpresa( int Id )
        {
            EmpresasTableAdapter da = new EmpresasTableAdapter();

            EmpresaDataSet ds = new EmpresaDataSet();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;
                da.FillBy( ds.Empresas, Id );
            }

            return ds.Empresas;
        }

        public static string SetUpdate( EmpresaDataSet ds )
        {
            EmpresasTableAdapter da = new EmpresasTableAdapter();

            SQLiteTransaction trans = null;

            try
            {
                using ( SQLiteConnection conn = Connections.ConnSQLite() )
                {
                    trans = conn.BeginTransaction();

                    da.Connection = conn;
                    da.CommandTimeout = 0;
                    da.Update( ds.Empresas );

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
