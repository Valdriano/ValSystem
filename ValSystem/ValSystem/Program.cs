using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Configuration conf = ConfigurationManager.OpenExeConfiguration( ConfigurationUserLevel.None );

            string path = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= {AppDomain.CurrentDomain.BaseDirectory + "ValSystemDB.mdb"};Persist Security Info=False;Jet OLEDB:Database Password=selva406";

            conf.ConnectionStrings.ConnectionStrings[ 2 ].ConnectionString = path;
            conf.Save( ConfigurationSaveMode.Modified );

            ConfigurationManager.RefreshSection( "appSetting" );

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new LoginForm() );
        }
    }
}
