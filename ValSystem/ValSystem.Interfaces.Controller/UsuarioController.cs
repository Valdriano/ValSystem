using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Linq;
using ValSystem.Connection;
using ValSystem.Interfaces.Model;
using ValSystem.Interfaces.Model.UsuarioDataSetTableAdapters;
using ValSystem.Model;

namespace ValSystem.Interfaces.Controller
{
    public class UsuarioController
    {
        public static UsuarioDataSet.ConsultaDataTable GetConsulta()
        {
            UsuarioDataSet ds = new UsuarioDataSet();

            ConsultaTableAdapter da = new ConsultaTableAdapter();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;
                da.Fill( ds.Consulta );
            }

            return ds.Consulta;
        }

        public static string SetUpdate( UsuarioDataSet ds )
        {
            UsuariosTableAdapter daUsuario = new UsuariosTableAdapter();

            SQLiteTransaction trans = null;

            try
            {

                using ( SQLiteConnection conn = Connections.ConnSQLite() )
                {
                    trans = conn.BeginTransaction();

                    daUsuario.Connection = conn;
                    daUsuario.CommandTimeout = 0;
                    daUsuario.Transactions = trans;
                    daUsuario.Update( ds.Usuarios );

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

        public static UsuarioDataSet.UsuariosDataTable GetUsuario( int Id )
        {
            UsuarioDataSet ds = new UsuarioDataSet();

            UsuariosTableAdapter da = new UsuariosTableAdapter();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;
                da.Fill( ds.Usuarios, Id );
            }

            return ds.Usuarios;
        }

        public static UsuarioDataSet.PerfisDataTable GetPerfil( int Id )
        {
            UsuarioDataSet ds = new UsuarioDataSet();

            PerfisTableAdapter da = new PerfisTableAdapter();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;
                da.Fill( ds.Perfis, Id );
            }

            return ds.Perfis;
        }

        public static string Excluir( int Id )
        {
            try
            {
                UsuarioDataSet ds = new UsuarioDataSet();

                ds.Usuarios.Clear();
                ds.Usuarios.Merge( GetUsuario( Id ) );

                if ( ds.Usuarios.Count == 0 )
                    return "Usuário não localizado!";

                ds.Usuarios[ 0 ].BeginEdit();
                ds.Usuarios[ 0 ].Delete();
                ds.Usuarios[ 0 ].EndEdit();

                return SetUpdate( ds );
            }
            catch ( Exception ex )
            {

                return ex.Message;
            }
        }
    }
}
