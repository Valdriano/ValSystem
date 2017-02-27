using System;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace ValSystem.Connection
{
    public class Connections : IConnections
    {
        public OleDbCommand Cmd( string cmd, params OleDbParameter[] parametros )
        {
            OleDbCommand Command = new OleDbCommand();

            try
            {
                using ( OleDbConnection conn = OpenConn() )
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

        public async Task<int> CmdAsync( string cmd, params OleDbParameter[] parametros )
        {
            OleDbCommand Command = new OleDbCommand();

            try
            {
                using ( OleDbConnection conn = OpenConn() )
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

        public DataSet Dados( string cmd, params OleDbParameter[] parametros )
        {
            DataSet ds = new DataSet();

            try
            {
                using ( OleDbConnection conn = OpenConn() )
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

        public int Delete( string cmd, params OleDbParameter[] parametros )
        {
            OleDbCommand Command = new OleDbCommand();

            try
            {
                using ( OleDbConnection conn = OpenConn() )
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

        public async Task<int> DeleteAsync( string cmd, params OleDbParameter[] parametros )
        {
            OleDbCommand Command = new OleDbCommand();

            try
            {
                using ( OleDbConnection conn = OpenConn() )
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

        public OleDbConnection OpenConn()
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
            finally
            {
                conn.Dispose();
            }
        }
    }
}
