using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValSystem.Connection;
using ValSystem.Integracao.Model;
using ValSystem.Integracao.Model.CampanhaLocaSMSDataSetTableAdapters;

namespace ValSystem.Integracao.Controller
{
    public class CampanhaLocaSMSController
    {
        public static CampanhaLocaSMSDataSet.CampanhaLocaSMSDataTable GetCampanhasLocaSMS()
        {
            CampanhaLocaSMSTableAdapter da = new CampanhaLocaSMSTableAdapter();

            CampanhaLocaSMSDataSet ds = new CampanhaLocaSMSDataSet();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;
                da.Fill( ds.CampanhaLocaSMS );
            }

            return ds.CampanhaLocaSMS;
        }

        public static CampanhaLocaSMSDataSet dsCampanhaLocaSMS( decimal Id )
        {
            CampanhaLocaSMSTableAdapter daCab = new CampanhaLocaSMSTableAdapter();
            CampanhaItemLocaSMSTableAdapter daItem = new CampanhaItemLocaSMSTableAdapter();

            CampanhaLocaSMSDataSet ds = new CampanhaLocaSMSDataSet();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                daCab.Connection = conn;
                daItem.Connection = conn;

                daCab.CommandTimeout = 0;
                daItem.CommandTimeout = 0;

                daCab.FillBy( ds.CampanhaLocaSMS, Id );
                daItem.Fill( ds.CampanhaItemLocaSMS, Id );
            }

            return ds;
        }

        public static CampanhaLocaSMSDataSet.ContatosLocaSMSDataTable GetContatosLocaSMS()
        {
            ContatosLocaSMSTableAdapter da = new ContatosLocaSMSTableAdapter();

            CampanhaLocaSMSDataSet ds = new CampanhaLocaSMSDataSet();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;
                da.Fill( ds.ContatosLocaSMS );
            }

            return ds.ContatosLocaSMS;
        }

        public static CampanhaLocaSMSDataSet.Seq_CampanhaLocaSMSDataTable GetSeq_CampanhaLocaSMS()
        {
            Seq_CampanhaLocaSMSTableAdapter da = new Seq_CampanhaLocaSMSTableAdapter();

            CampanhaLocaSMSDataSet ds = new CampanhaLocaSMSDataSet();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;
                da.Fill( ds.Seq_CampanhaLocaSMS );
            }

            return ds.Seq_CampanhaLocaSMS;
        }

        public static string SetUpdate( CampanhaLocaSMSDataSet ds )
        {
            ContatosLocaSMSTableAdapter daContatoLocaSMS = new ContatosLocaSMSTableAdapter();
            CampanhaLocaSMSTableAdapter daCampanhaLocaSMS = new CampanhaLocaSMSTableAdapter();
            CampanhaItemLocaSMSTableAdapter daCampanhaItemLocaSMS = new CampanhaItemLocaSMSTableAdapter();
            Seq_CampanhaLocaSMSTableAdapter daSeq_CampanhaLocaSMS = new Seq_CampanhaLocaSMSTableAdapter();

            SQLiteTransaction trans = null;

            try
            {
                using ( SQLiteConnection conn = Connections.ConnSQLite() )
                {
                    trans = conn.BeginTransaction();

                    daContatoLocaSMS.Connection = conn;
                    daCampanhaLocaSMS.Connection = conn;
                    daCampanhaItemLocaSMS.Connection = conn;
                    daSeq_CampanhaLocaSMS.Connection = conn;

                    daContatoLocaSMS.CommandTimeout = 0;
                    daCampanhaLocaSMS.CommandTimeout = 0;
                    daCampanhaItemLocaSMS.CommandTimeout = 0;
                    daSeq_CampanhaLocaSMS.CommandTimeout = 0;

                    daContatoLocaSMS.Transactions = trans;
                    daCampanhaLocaSMS.Transactions = trans;
                    daCampanhaItemLocaSMS.Transactions = trans;
                    daSeq_CampanhaLocaSMS.Transactions = trans;

                    daContatoLocaSMS.Update( ds.ContatosLocaSMS );
                    daCampanhaLocaSMS.Update( ds.CampanhaLocaSMS );
                    daCampanhaItemLocaSMS.Update( ds.CampanhaItemLocaSMS );
                    daSeq_CampanhaLocaSMS.Update( ds.Seq_CampanhaLocaSMS );

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

        public static CampanhaLocaSMSDataSet.ConsultaItemDataTable GetConsultaItem( int? Id = null )
        {
            ConsultaItemTableAdapter da = new ConsultaItemTableAdapter();

            CampanhaLocaSMSDataSet ds = new CampanhaLocaSMSDataSet();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;

                if ( Id == null )
                {
                    da.Fill( ds.ConsultaItem );
                }
                else
                {
                    da.FillBy( ds.ConsultaItem, ( int )Id );
                }
            }

            return ds.ConsultaItem;
        }

        public static CampanhaLocaSMSDataSet.UsuariosLocaSMSDataTable GetUsuarioLocaSMS( int Id )
        {
            UsuariosLocaSMSTableAdapter da = new UsuariosLocaSMSTableAdapter();

            CampanhaLocaSMSDataSet ds = new CampanhaLocaSMSDataSet();

            using ( SQLiteConnection conn = Connections.ConnSQLite() )
            {
                da.Connection = conn;
                da.CommandTimeout = 0;
                da.Fill( ds.UsuariosLocaSMS, Id );
            }

            return ds.UsuariosLocaSMS;
        }
    }
}
