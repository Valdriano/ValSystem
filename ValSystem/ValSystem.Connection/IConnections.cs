using System;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace ValSystem.Connection
{
    interface IConnections
    {
        OleDbConnection OpenConn();
        OleDbCommand Cmd( string cmd, params OleDbParameter[] parametros );
        Task<int> CmdAsync( string cmd, params OleDbParameter[] parametros );
        int Delete( string cmd, params OleDbParameter[] parametros );
        Task<int> DeleteAsync( string cmd, params OleDbParameter[] parametros );
        DataSet Dados( string cmd, params OleDbParameter[] parametros );
    }
}
