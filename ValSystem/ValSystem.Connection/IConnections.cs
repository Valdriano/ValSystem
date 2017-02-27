using System;
using System.Data.OleDb;

namespace ValSystem.Connection
{
    interface IConnections
    {
        OleDbConnection OpenConn();
        OleDbCommand Cmd( OleDbConnection conn, string cmd, params OleDbParameter[] paramentos );

    }
}
