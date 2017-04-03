using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace ValSystem.Connection
{
    interface IConnections
    {
        OleDbConnection OpenOleDbConn();
        OleDbCommand CmdOleDb( string cmd, params OleDbParameter[] parametros );
        Task<int> CmdOleDbAsync( string cmd, params OleDbParameter[] parametros );
        int DeleteOleDb( string cmd, params OleDbParameter[] parametros );
        Task<int> DeleteOleDbAsync( string cmd, params OleDbParameter[] parametros );
        DataSet DadosOleDb( string cmd, params OleDbParameter[] parametros );
        SQLiteConnection OpenSQLiteConn();
        SQLiteCommand CmdSQLite( string cmd, params SQLiteParameter[] parametros );
        int DeleteSQLite( string cmd, params SQLiteParameter[] parametros );
        DataSet DadosSQLite( string cmd, params SQLiteParameter[] parametros );
    }
}
