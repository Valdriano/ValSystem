using System.Data.OleDb;
using ValSystem.Connection;
using ValSystem.Interfaces.Model;
using ValSystem.Interfaces.Model.UsuarioDataSetTableAdapters;

namespace ValSystem.Interfaces.Controller
{
    public class UsuarioController
    {
        public static UsuarioDataSet.UsuarioDataTable GetUsuario( int IdUsuario )
        {
            UsuarioTableAdapter da = new UsuarioTableAdapter();
            UsuarioDataSet ds = new UsuarioDataSet();

            using ( OleDbConnection conn = new Connections().OpenConn() )
            {
                da.Connection = conn;
                da.FillById( ds.Usuario, IdUsuario );
            }

            return ds.Usuario;
        }

        public static UsuarioDataSet.ConsultaDataTable GetConsulta()
        {
            ConsultaTableAdapter da = new ConsultaTableAdapter();
            UsuarioDataSet ds = new UsuarioDataSet();

            using ( OleDbConnection conn = new Connections().OpenConn() )
            {
                da.Connection = conn;
                da.Fill( ds.Consulta );
            }

            return ds.Consulta;
        }
    }
}
