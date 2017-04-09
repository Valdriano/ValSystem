using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ValSystem.Util
{
    public static class AppUtil
    {
        public static bool AceitaNumero( char c )
        {
            return !( Enumero( c ) || c == ( char )Keys.Back );
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

        public static string DiretorioExecutacao
        {
            get
            {
                //return new Uri( Assembly.GetExecutingAssembly().CodeBase ).LocalPath;
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }

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

        public static DataSet GetLerArquivo( bool bPrimeiraLinhaColunas, string fileName )
        {
            string strFile = fileName;
            char separator = ';';
            bool isRowOneHeader = bPrimeiraLinhaColunas;

            DataTable csvDataTable = new DataTable();

            DataSet myDataSet = new DataSet();

            DataTable newdt = new DataTable( "Erro" );

            DataColumn desc = new DataColumn();
            desc.DataType = Type.GetType( "System.String" );
            desc.ColumnName = "Descricao";
            desc.DefaultValue = string.Empty;
            newdt.Columns.Add( desc );

            DataColumn[] keys = new DataColumn[ 1 ];
            keys[ 0 ] = desc;
            newdt.PrimaryKey = keys;

            DataTable dt;

            dt = newdt;

            DataRow dr = dt.NewRow();

            try
            {
                string[] csvData = File.ReadAllLines( strFile );

                if ( csvData.Length > 0 )
                {
                    string[] headings = csvData[ 0 ].Split( separator );

                    int intRowIndex = 0;

                    if ( isRowOneHeader )
                    {
                        for ( int i = 0; i < headings.Length; i++ )
                            csvDataTable.Columns.Add( headings[ i ].ToString() );

                        intRowIndex++;
                    }
                    else
                    {
                        for ( int i = 0; i < headings.Length; i++ )
                            csvDataTable.Columns.Add( "Coluna" + ( i + 1 ).ToString() );

                    }
                    for ( int i = intRowIndex; i < csvData.Length; i++ )
                    {
                        DataRow row = csvDataTable.NewRow();

                        for ( int j = 0; j < headings.Length; j++ )
                            row[ j ] = csvData[ i ].Split( separator )[ j ];

                        csvDataTable.Rows.Add( row );
                    }
                }

                myDataSet.Tables.Add( csvDataTable );

                return myDataSet;
            }
            catch ( IOException ex )
            {
                myDataSet.Tables.Add( csvDataTable );

                dr[ "Descricao" ] = ex.Message;
                dt.Rows.Add( dr );

                myDataSet.Tables.Add( dt );

                return myDataSet;

            }
            catch ( Exception ex )
            {
                myDataSet.Tables.Add( csvDataTable );

                dr[ "Descricao" ] = ex.Message;
                dt.Rows.Add( dr );

                myDataSet.Tables.Add( dt );

                return myDataSet;
            }
        }

        public static List<string> ListaClasses( Assembly assembly )
        {
            List<string> listaClasses = new List<string>();

            foreach ( Type type in assembly.GetTypes() )
                listaClasses.Add( type.FullName );

            return listaClasses;
        }

        public static DialogResult MensagemAviso( string aviso )
        {
            return MessageBox.Show( aviso, "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning );
        }

        public static DialogResult MensagemDialogo( string mensagem )
        {
            return MessageBox.Show( mensagem, "Questionar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
        }

        public static DialogResult MensagemErro( Exception ex )
        {
            return MessageBox.Show( $"Erro:\n\n{ex.Message}", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }

        public static DialogResult MensagemSucesso( string mensagem )
        {
            return MessageBox.Show( mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        public static string RemoveEspaco( this object valor )
        {
            string novo = "";
            string _valor = Convert.ToString( valor );

            for ( int i = 0; i < _valor.Length; i++ )
            {
                novo += _valor[ i ].ToString() == "\n" | _valor[ i ].ToString() == "\r" ? "" : _valor[ i ].ToString().Trim();
            }

            return novo;
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

    }
}
