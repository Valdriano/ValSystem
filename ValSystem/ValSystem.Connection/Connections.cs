using System;
using System.Data.OleDb;

namespace ValSystem.Connection
{
    public class Connections : IConnections
    {
        public OleDbCommand Cmd( OleDbConnection conn, string cmd, params OleDbParameter[] paramentos )
        {
            OleDbCommand Command = new OleDbCommand();

            try
            {
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

        public OleDbConnection OpenConn()
        {
            OleDbConnection conn = new OleDbConnection();

            try
            {
                conn.ConnectionString = $"";

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
