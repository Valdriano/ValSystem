using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace ValSystem.Connection
{
    public class Connections : IConnections
    {
        public OleDbCommand CmdOleDb( string cmd, params OleDbParameter[] parametros )
        {
            OleDbCommand Command = new OleDbCommand();

            try
            {
                using ( OleDbConnection conn = OpenOleDbConn() )
                {
                    Command.Connection = conn;
                    Command.CommandType = CommandType.Text;
                    Command.CommandText = cmd;

                    foreach ( OleDbParameter parametro in parametros )
                        Command.Parameters.Add( parametro );

                    Command.ExecuteNonQuery();
                }

                return Command;
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
            finally
            {
                Command.Dispose();
            }
        }

        public async Task<int> CmdOleDbAsync( string cmd, params OleDbParameter[] parametros )
        {
            OleDbCommand Command = new OleDbCommand();

            try
            {
                using ( OleDbConnection conn = OpenOleDbConn() )
                {
                    Command.Connection = conn;
                    Command.CommandType = CommandType.Text;
                    Command.CommandText = cmd;

                    foreach ( OleDbParameter parametro in parametros )
                        Command.Parameters.Add( parametro );

                    return await Command.ExecuteNonQueryAsync();
                }
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
            finally
            {
                Command.Dispose();
            }
        }

        public SQLiteCommand CmdSQLite( string cmd, params SQLiteParameter[] parametros )
        {
            SQLiteCommand Command = new SQLiteCommand();

            try
            {
                using ( SQLiteConnection conn = OpenSQLiteConn() )
                {
                    Command.Connection = conn;
                    Command.CommandType = CommandType.Text;
                    Command.CommandText = cmd;

                    foreach ( SQLiteParameter parametro in parametros )
                        Command.Parameters.Add( parametro );

                    Command.ExecuteNonQuery();
                }

                return Command;
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
            finally
            {
                Command.Dispose();
            }
        }

        public static SQLiteConnection ConnSQLite()
        {
            return new Connections().OpenSQLiteConn();
        }

        public DataSet DadosOleDb( string cmd, params OleDbParameter[] parametros )
        {
            DataSet ds = new DataSet();

            try
            {
                using ( OleDbConnection conn = OpenOleDbConn() )
                {
                    OleDbCommand Command = conn.CreateCommand();

                    Command.CommandType = CommandType.Text;
                    Command.CommandText = cmd;

                    foreach ( OleDbParameter parametro in parametros )
                        Command.Parameters.Add( parametro );

                    DataTable dt = new DataTable();

                    OleDbDataReader reader = Command.ExecuteReader();

                    dt.Load( reader );

                    ds.Tables.Add( dt );
                }

                return ds;
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
            finally
            {
                ds.Dispose();
            }
        }

        public DataSet DadosSQLite( string cmd, params SQLiteParameter[] parametros )
        {
            DataSet ds = new DataSet();

            try
            {
                using ( SQLiteConnection conn = OpenSQLiteConn() )
                {
                    SQLiteCommand Command = conn.CreateCommand();

                    Command.CommandType = CommandType.Text;
                    Command.CommandText = cmd;

                    foreach ( SQLiteParameter parametro in parametros )
                        Command.Parameters.Add( parametro );

                    DataTable dt = new DataTable();

                    SQLiteDataReader reader = Command.ExecuteReader();

                    dt.Load( reader );

                    ds.Tables.Add( dt );
                }

                return ds;
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
            finally
            {
                ds.Dispose();
            }
        }

        public int DeleteOleDb( string cmd, params OleDbParameter[] parametros )
        {
            OleDbCommand Command = new OleDbCommand();

            try
            {
                using ( OleDbConnection conn = OpenOleDbConn() )
                {
                    Command.Connection = conn;
                    Command.CommandType = CommandType.Text;
                    Command.CommandText = cmd;

                    foreach ( OleDbParameter parametro in parametros )
                        Command.Parameters.Add( parametro );

                    return Command.ExecuteNonQuery();
                }
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
            finally
            {
                Command.Dispose();
            }
        }

        public async Task<int> DeleteOleDbAsync( string cmd, params OleDbParameter[] parametros )
        {
            OleDbCommand Command = new OleDbCommand();

            try
            {
                using ( OleDbConnection conn = OpenOleDbConn() )
                {
                    Command.Connection = conn;
                    Command.CommandType = CommandType.Text;
                    Command.CommandText = cmd;

                    foreach ( OleDbParameter parametro in parametros )
                        Command.Parameters.Add( parametro );

                    return await Command.ExecuteNonQueryAsync();
                }
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
            finally
            {
                Command.Dispose();
            }
        }

        public int DeleteSQLite( string cmd, params SQLiteParameter[] parametros )
        {
            SQLiteCommand Command = new SQLiteCommand();

            try
            {
                using ( SQLiteConnection conn = OpenSQLiteConn() )
                {
                    Command.Connection = conn;
                    Command.CommandType = CommandType.Text;
                    Command.CommandText = cmd;

                    foreach ( SQLiteParameter parametro in parametros )
                        Command.Parameters.Add( parametro );

                    return Command.ExecuteNonQuery();
                }
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
            finally
            {
                Command.Dispose();
            }
        }

        public OleDbConnection OpenOleDbConn()
        {
            OleDbConnection conn = new OleDbConnection();

            try
            {
                conn.ConnectionString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={AppDomain.CurrentDomain.BaseDirectory + "ValSystemDB.mdb"};Persist Security Info=False;Jet OLEDB:Database Password=selva406";

                conn.Open();

                return conn;
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
        }

        public SQLiteConnection OpenSQLiteConn()
        {
            SQLiteConnection conn = new SQLiteConnection();

            try
            {
                conn.ConnectionString = @"data source=.\db\DataBase\ValSystemDb.sqlite;foreign keys=true";

                conn.Open();

                return conn;
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
        }
    }
}
