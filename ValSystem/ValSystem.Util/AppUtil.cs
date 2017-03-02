using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ValSystem.Util
{
    public static class AppUtil
    {
        public static bool Enumero( this object valor )
        {
            string valores = Convert.ToString( valor );

            if ( string.IsNullOrWhiteSpace( valores ) )
                return false;

            foreach ( char ch in valores )
            {
                if ( !char.IsNumber( ch ) )
                {
                    return false;
                }
            }

            return true;
        }

        public static bool Vazio( this object valor )
        {
            string valores = Convert.ToString( valor );

            if ( string.IsNullOrEmpty( valores ) )
                return true;
            else if ( string.IsNullOrWhiteSpace( valores ) )
                return true;
            else
                return false;
        }

        public static string DiretorioExecutacao
        {
            get
            {
                //return new Uri( Assembly.GetExecutingAssembly().CodeBase ).LocalPath;
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }

        public static List<string> CarregarAssembly( string Path )
        {
            List<string> listaAssembly = new List<string>();

            try
            {
                string[] arquivos = Directory.GetFiles( Path ).Where( w => w.EndsWith( "View.dll", StringComparison.InvariantCultureIgnoreCase ) ).ToArray();

                foreach ( string NomeAssembly in arquivos )
                    listaAssembly.Add( NomeAssembly );

                return listaAssembly;
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
        }

        public static List<string> ListaClasses( Assembly assembly )
        {
            List<string> listaClasses = new List<string>();

            foreach ( Type type in assembly.GetTypes() )
                listaClasses.Add( type.FullName );

            return listaClasses;
        }
    }
}
