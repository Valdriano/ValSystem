using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ValSystem.Integracao.Controller;
using ValSystem.Integracao.Model;
using ValSystem.Util;

namespace ValSystem.Integracao.View
{
    public partial class CampanhaLocaSMSEditForm : ValSystem.View.DataEditForm
    {
        protected decimal IdCampanhaLocaSMS;
        protected CampanhaLocaSMSViewerForm oViewer;
        protected CampanhaLocaSMSDataSet.CampanhaLocaSMSRow drCampanhaLocaSMS;
        public CampanhaLocaSMSEditForm( decimal IdCampanhaLocaSMS, CampanhaLocaSMSViewerForm oViewer )
        {
            InitializeComponent();

            this.IdCampanhaLocaSMS = IdCampanhaLocaSMS;
            this.oViewer = oViewer;
        }

        private void CampanhaLocaSMSEditForm_Shown( object sender, EventArgs e )
        {
            try
            {
                Application.DoEvents();
                Cursor.Current = Cursors.WaitCursor;

                this.frmApp.Mensagem_Status( "Carregando Registros por favor aguarde..." );

                this.campanhaLocaSMSDataSet.Clear();
                this.campanhaLocaSMSDataSet.Merge( CampanhaLocaSMSController.dsCampanhaLocaSMS( this.IdCampanhaLocaSMS ) );

                if ( this.campanhaLocaSMSDataSet.CampanhaLocaSMS.Count <= 0 )
                {
                    //this.campanhaLocaSMSDataSet.ContatosLocaSMS.Merge( CampanhaLocaSMSController.GetContatosLocaSMS() );

                    this.campanhaLocaSMSDataSet.Seq_CampanhaLocaSMS.Merge( CampanhaLocaSMSController.GetSeq_CampanhaLocaSMS() );

                    if ( this.campanhaLocaSMSDataSet.Seq_CampanhaLocaSMS.Count == 0 )
                        this.campanhaLocaSMSDataSet.Seq_CampanhaLocaSMS.AddSeq_CampanhaLocaSMSRow( 1 );
                    else
                    {
                        this.campanhaLocaSMSDataSet.Seq_CampanhaLocaSMS[ 0 ].BeginEdit();
                        this.campanhaLocaSMSDataSet.Seq_CampanhaLocaSMS[ 0 ].Id += 1;
                        this.campanhaLocaSMSDataSet.Seq_CampanhaLocaSMS[ 0 ].EndEdit();
                    }

                    string ret = CampanhaLocaSMSController.SetUpdate( this.campanhaLocaSMSDataSet );

                    if ( ret != string.Empty )
                        throw new Exception( ret );

                    this.IdCampanhaLocaSMS = this.campanhaLocaSMSDataSet.Seq_CampanhaLocaSMS[ 0 ].Id;

                    this.drCampanhaLocaSMS = this.campanhaLocaSMSDataSet.CampanhaLocaSMS.NewCampanhaLocaSMSRow();

                }
                else
                {
                    this.drCampanhaLocaSMS = this.campanhaLocaSMSDataSet.CampanhaLocaSMS[ 0 ];

                    this.BloquearMenu( true );
                }
            }
            catch ( Exception ex )
            {

                AppUtil.MensagemErro( ex );
            }
            finally
            {
                Cursor.Current = Cursors.Default;

                this.frmApp.Mensagem_Status();
            }
        }

        private void advancedDataGridView1_SortStringChanged( object sender, EventArgs e )
        {
            this.bindingSourceConsultaItem.Sort = this.advancedDataGridView1.SortString;
        }

        private void advancedDataGridView1_FilterStringChanged( object sender, EventArgs e )
        {
            this.bindingSourceConsultaItem.Filter = this.advancedDataGridView1.FilterString;
        }

        private void bindingSourceConsultaItem_ListChanged( object sender, ListChangedEventArgs e )
        {
            this.tsslTotal.Text = $"Total {this.bindingSourceConsultaItem.Count}";
        }

        private void IdUsuarioLocaSMStextBox_KeyPress( object sender, KeyPressEventArgs e )
        {
            e.Handled = AppUtil.AceitaNumero( e.KeyChar );
        }

        private void IdUsuarioLocaSMStextBox_Leave( object sender, EventArgs e )
        {
            if ( !this.IdUsuarioLocaSMStextBox.Text.Vazio() )
            {
                this.campanhaLocaSMSDataSet.UsuariosLocaSMS.Clear();
                this.campanhaLocaSMSDataSet.UsuariosLocaSMS.Merge( CampanhaLocaSMSController.GetUsuarioLocaSMS( Convert.ToInt32( this.IdUsuarioLocaSMStextBox.Text ) ) );

                if ( this.campanhaLocaSMSDataSet.UsuariosLocaSMS.Count > 0 )
                {
                    this.DescricaoUsuarioLocaSMStextBox.Text = this.campanhaLocaSMSDataSet.UsuariosLocaSMS[ 0 ].Descricao;
                }
                else
                {
                    AppUtil.MensagemAviso( "Usuário LocaSMS não localizado!" );

                    this.IdUsuarioLocaSMStextBox.Focus();
                    this.IdUsuarioLocaSMStextBox.Select( 0, this.IdUsuarioLocaSMStextBox.Text.Length );

                    return;
                }
            }
            else
            {
                this.DescricaoUsuarioLocaSMStextBox.Clear();
            }
        }

        public override void Gravar( object sender, EventArgs e )
        {
            base.Gravar( sender, e );

            try
            {
                if ( this.IdUsuarioLocaSMStextBox.Text.Vazio() )
                {
                    AppUtil.MensagemAviso( "Informe o usuário LocaSMS!" );

                    this.IdUsuarioLocaSMStextBox.Focus();

                    return;
                }

                if ( this.DescricaotextBox.Text.Vazio() )
                {
                    AppUtil.MensagemAviso( "Informe a descrição!" );

                    this.DescricaotextBox.Focus();

                    return;
                }

                if ( this.MensagemtextBox.Text.Vazio() )
                {
                    AppUtil.MensagemAviso( "Informe a mensagem!" );

                    this.MensagemtextBox.Focus();

                    return;
                }

                bool sel = false;

                foreach ( DataGridViewRow row in this.advancedDataGridView1.Rows )
                {
                    if ( row.Cells[ 0 ].Value == null )
                        continue;
                    else
                    {
                        if ( ( bool )row.Cells[ 0 ].Value )
                        {
                            sel = true;

                            break;
                        }
                    }
                }

                if ( !sel )
                {
                    AppUtil.MensagemAviso( "Selecione pelo menos um contato para envia a mensagem!" );

                    return;
                }

                DialogResult dialog = AppUtil.MensagemDialogo( "Atenção deseja gravar esta campanha?" );

                if ( dialog != DialogResult.Yes )
                    return;

                Application.DoEvents();
                Cursor.Current = Cursors.WaitCursor;

                this.frmApp.Mensagem_Status( "Gravando campanha por favor aguarde..." );

                string retorno = "";

                this.drCampanhaLocaSMS.AgendaSMS = false;
                this.drCampanhaLocaSMS.Descricao = this.DescricaotextBox.Text;
                this.drCampanhaLocaSMS.IdUsuarioLocaSMS = Convert.ToInt32( this.IdUsuarioLocaSMStextBox.Text );
                this.drCampanhaLocaSMS.Mensagem = this.MensagemtextBox.Text;
                this.drCampanhaLocaSMS.retornoLocaSMS = "";

                if ( this.drCampanhaLocaSMS.RowState == DataRowState.Detached )
                {
                    this.drCampanhaLocaSMS.Data = this.DatadateTimePicker.Value;

                    this.campanhaLocaSMSDataSet.CampanhaLocaSMS.AddCampanhaLocaSMSRow( this.drCampanhaLocaSMS );
                }
                else
                {
                    this.drCampanhaLocaSMS.EndEdit();
                }

                this.campanhaLocaSMSDataSet.CampanhaItemLocaSMS.PrimaryKey = new DataColumn[] { this.campanhaLocaSMSDataSet.CampanhaItemLocaSMS.IdContatoLocaSMSColumn };

                foreach ( DataGridViewRow drGrid in this.advancedDataGridView1.Rows )
                {
                    if ( drGrid.Cells[ 0 ].Value == null )
                        continue;
                    else
                    {
                        if ( ( bool )drGrid.Cells[ 0 ].Value )
                        {
                            CampanhaLocaSMSDataSet.ContatosLocaSMSRow drContatoLocaSMS = null;
                            CampanhaLocaSMSDataSet.CampanhaItemLocaSMSRow drCampanhaItemLocaSMS = null;

                            drContatoLocaSMS = this.campanhaLocaSMSDataSet.ContatosLocaSMS.Single( s => s.Id == Convert.ToDecimal( drGrid.Cells[ 1 ].Value ) );

                            drCampanhaItemLocaSMS = this.campanhaLocaSMSDataSet.CampanhaItemLocaSMS.Rows.Find( drContatoLocaSMS.Id ) as CampanhaLocaSMSDataSet.CampanhaItemLocaSMSRow;

                            if ( drCampanhaItemLocaSMS == null )
                            {
                                drCampanhaItemLocaSMS = this.campanhaLocaSMSDataSet.CampanhaItemLocaSMS.NewCampanhaItemLocaSMSRow();

                                drCampanhaItemLocaSMS.IdCampanhaLocaSMS = this.IdCampanhaLocaSMS;
                                drCampanhaItemLocaSMS.Data = this.DatadateTimePicker.Value;
                                drCampanhaItemLocaSMS.DataEnvio = drCampanhaItemLocaSMS.Data;
                            }
                            else
                            {
                                drCampanhaItemLocaSMS.BeginEdit();
                            }

                            drCampanhaItemLocaSMS.CodigoRef = this.IdCampanhaLocaSMS.ToString();
                            drCampanhaItemLocaSMS.IdContatoLocaSMS = drContatoLocaSMS.Id;

                            if ( drCampanhaItemLocaSMS.RowState == DataRowState.Detached )
                            {
                                this.campanhaLocaSMSDataSet.CampanhaItemLocaSMS.AddCampanhaItemLocaSMSRow( drCampanhaItemLocaSMS );
                            }
                            else
                            {
                                drCampanhaItemLocaSMS.EndEdit();
                            }
                        }
                    }
                }

                retorno = CampanhaLocaSMSController.SetUpdate( this.campanhaLocaSMSDataSet );

                if ( retorno != string.Empty )
                    throw new Exception( retorno );

                AppUtil.MensagemSucesso( "Campanha salva com sucesso!" );

                this.Close();
                this.oViewer.Atualizar( sender, e );
            }
            catch ( Exception ex )
            {

                AppUtil.MensagemErro( ex );
            }
            finally
            {
                Cursor.Current = Cursors.Default;

                this.frmApp.Mensagem_Status();
            }
        }
    }
}
