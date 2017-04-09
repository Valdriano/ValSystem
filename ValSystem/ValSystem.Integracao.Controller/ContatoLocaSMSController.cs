using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValSystem.Connection;
using ValSystem.Integracao.Model;
using ValSystem.Integracao.Model.ContatoLocaSMSDataSetTableAdapters;
using ValSystem.Util;

namespace ValSystem.Integracao.Controller
{
    public class ContatoLocaSMSController
    {
        public static ContatoLocaSMSDataSet.ContatosLocaSMSDataTable GetContatos()
        {
            ContatosLocaSMSTableAdapter da = new ContatosLocaSMSTableAdapter();

            ContatoLocaSMSDataSet ds = new ContatoLocaSMSDataSet();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;
                da.Fill( ds.ContatosLocaSMS );
            }

            return ds.ContatosLocaSMS;
        }

        public static ContatoLocaSMSDataSet.ContatosLocaSMSDataTable GetContato( int Id )
        {
            ContatosLocaSMSTableAdapter da = new ContatosLocaSMSTableAdapter();

            ContatoLocaSMSDataSet ds = new ContatoLocaSMSDataSet();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;
                da.FillBy( ds.ContatosLocaSMS, Id );
            }

            return ds.ContatosLocaSMS;
        }

        public static ContatoLocaSMSDataSet.Seq_ContatoLocaSMSDataTable GetSeq_ContatoLocaSMS()
        {
            Seq_ContatoLocaSMSTableAdapter da = new Seq_ContatoLocaSMSTableAdapter();

            ContatoLocaSMSDataSet ds = new ContatoLocaSMSDataSet();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;
                da.Fill( ds.Seq_ContatoLocaSMS );
            }

            return ds.Seq_ContatoLocaSMS;
        }

        public static string SetUpdate( ContatoLocaSMSDataSet ds )
        {
            ContatosLocaSMSTableAdapter daContatoLocaSMS = new ContatosLocaSMSTableAdapter();

            SQLiteTransaction trans = null;

            try
            {
                using ( SQLiteConnection conn = Connections.ConnSQLite() )
                {
                    trans = conn.BeginTransaction();

                    daContatoLocaSMS.Connection = conn;
                    daContatoLocaSMS.CommandTimeout = 0;
                    daContatoLocaSMS.Transactions = trans;
                    daContatoLocaSMS.Update( ds.ContatosLocaSMS );


                    trans.Commit();
                }

                return "";
            }
            catch ( Exception ex )
            {
                if ( trans != null )
                    trans.Rollback();

                return ex.Message;
            }
        }

        private static string SetUpdateSeq( ContatoLocaSMSDataSet.Seq_ContatoLocaSMSDataTable dt )
        {
            Seq_ContatoLocaSMSTableAdapter daSeq_ContatoLocaSMS = new Seq_ContatoLocaSMSTableAdapter();

            SQLiteTransaction trans = null;

            try
            {
                using ( SQLiteConnection conn = Connections.ConnSQLite() )
                {
                    trans = conn.BeginTransaction();

                    daSeq_ContatoLocaSMS.Connection = conn;
                    daSeq_ContatoLocaSMS.CommandTimeout = 0;
                    daSeq_ContatoLocaSMS.Transactions = trans;
                    daSeq_ContatoLocaSMS.Update( dt );

                    trans.Commit();
                }

                return "";
            }
            catch ( Exception ex )
            {
                if ( trans != null )
                    trans.Rollback();

                return ex.Message;
            }
        }

        public static string ImportaContatosLocaSMS( bool Cab, string diretorio )
        {
            ContatoLocaSMSDataSet ds = new ContatoLocaSMSDataSet();
            ContatoLocaSMSDataSet.Seq_ContatoLocaSMSDataTable dtSeq = new ContatoLocaSMSDataSet.Seq_ContatoLocaSMSDataTable();
            DataSet dsFile = new DataSet();
            try
            {
                dsFile = AppUtil.GetLerArquivo( Cab, diretorio );

                if ( dsFile != null && dsFile.Tables.Count > 1 )
                {
                    return dsFile.Tables[ 1 ].Rows[ 0 ][ 0 ].ToString();
                }
                else if ( dsFile != null )
                {
                    ds.ContatosLocaSMS.Merge( GetContatos() );
                    ds.ContatosLocaSMS.PrimaryKey = new DataColumn[] { ds.ContatosLocaSMS.NomeColumn };

                    dtSeq.Merge( GetSeq_ContatoLocaSMS() );

                    foreach ( DataRow dr in dsFile.Tables[ 0 ].Rows )
                    {
                        ContatoLocaSMSDataSet.ContatosLocaSMSRow drContatosLocaSMS = null;

                        string nome = dr[ 0 ].ToString().Length > 40 ? dr[ 0 ].ToString().Substring( 0, 39 ) : dr[ 0 ].ToString();

                        string[] cels = { dr.IsNull( 1 ) ? "" : dr[ 1 ].ToString(), dr.IsNull( 2 ) ? "" : dr[ 2 ].ToString() };

                        drContatosLocaSMS = ds.ContatosLocaSMS.Rows.Find( nome ) as ContatoLocaSMSDataSet.ContatosLocaSMSRow;

                        if ( drContatosLocaSMS == null )
                        {
                            drContatosLocaSMS = ds.ContatosLocaSMS.NewContatosLocaSMSRow();

                            if ( dtSeq.Count == 0 )
                            {
                                dtSeq.AddSeq_ContatoLocaSMSRow( 1 );
                            }
                            else
                            {
                                dtSeq[ 0 ].BeginEdit();
                                dtSeq[ 0 ].Id += 1;
                                dtSeq[ 0 ].EndEdit();
                            }

                            string ret = SetUpdateSeq( dtSeq );

                            if ( ret != string.Empty )
                            {
                                return ret;
                            }

                            drContatosLocaSMS.Id = dtSeq[ 0 ].Id;
                            drContatosLocaSMS.Nome = nome;
                            drContatosLocaSMS.DataCadastro = DateTime.Now;
                        }
                        else
                        {
                            drContatosLocaSMS.BeginEdit();

                            drContatosLocaSMS.DataAlteracao = DateTime.Now;
                        }

                        foreach ( string cel in cels )
                        {
                            int novo = 0;

                            if ( cel.Length < 8 )
                                continue;

                            if ( cel.Substring( 0 ) == "9" )
                                goto Proximo;

                            if ( cel.Substring( 0 ) == "8" )
                                goto Proximo;

                            Proximo:
                            if ( cel.Length == 8 )
                                novo = Convert.ToInt32( string.Concat( "9", cel ) );
                            else if ( cel.Length == 9 )
                                novo = Convert.ToInt32( cel );
                            else if ( cel.Length == 10 )
                                novo = Convert.ToInt32( string.Concat( "9", cel.Substring( 0, 8 ) ) );
                            else if ( cel.Length == 11 )
                                novo = Convert.ToInt32( string.Concat( "9", cel.RemoveEspaco().Substring( 2, 8 ) ) );
                            else
                                continue;

                            if ( drContatosLocaSMS.IsCelular1Null() )
                            {
                                drContatosLocaSMS.Celular1 = novo;
                            }
                            else if ( drContatosLocaSMS.IsCelular2Null() )
                            {
                                drContatosLocaSMS.Celular2 = novo;
                            }
                            else if ( drContatosLocaSMS.IsCelular3Null() )
                            {
                                drContatosLocaSMS.Celular3 = novo;
                            }
                            else if ( drContatosLocaSMS.IsCelular4Null() )
                            {
                                drContatosLocaSMS.Celular4 = novo;
                            }
                        }

                        if ( drContatosLocaSMS.RowState == DataRowState.Detached )
                        {
                            ds.ContatosLocaSMS.AddContatosLocaSMSRow( drContatosLocaSMS );
                        }
                        else
                        {
                            drContatosLocaSMS.EndEdit();
                        }
                    }
                }

                return SetUpdate( ds );
            }
            catch ( Exception ex )
            {
                return ex.Message;
            }
            finally
            {
                ds.Dispose();
                dsFile.Dispose();
            }
        }
    }
}
