using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValSystem.Integracao.Controller;
using ValSystem.Integracao.Model;
using ValSystem.Util;

namespace ValSystem.Integracao.View
{
    public partial class UsuarioLocaSMSEditForm : ValSystem.View.DataEditForm
    {
        protected int Id;
        protected UsuarioLocaSMSViewerForm oViewer;
        protected UsuarioLocaSMSDataSet.UsuariosLocaSMSRow drUsuarioLocaSMS;
        public UsuarioLocaSMSEditForm( int Id, UsuarioLocaSMSViewerForm oViewer )
        {
            InitializeComponent();

            this.Id = Id;
            this.oViewer = oViewer;
        }

        private void UsuarioLocaSMSEditForm_Shown( object sender, EventArgs e )
        {
            this.usuarioLocaSMSDataSet.UsuariosLocaSMS.Clear();
            this.usuarioLocaSMSDataSet.UsuariosLocaSMS.Merge( UsuarioLocaSMSController.GetUsuarioLocaSMS( this.Id ) );

            if ( this.usuarioLocaSMSDataSet.UsuariosLocaSMS.Count <= 0 )
            {
                this.drUsuarioLocaSMS = this.usuarioLocaSMSDataSet.UsuariosLocaSMS.NewUsuariosLocaSMSRow();
            }
            else
            {
                this.drUsuarioLocaSMS = this.usuarioLocaSMSDataSet.UsuariosLocaSMS[ 0 ];

                this.IdtextBox.Text = this.drUsuarioLocaSMS.Id.ToString();
                this.DescricaotextBox.Text = this.drUsuarioLocaSMS.Descricao;
                this.LogintextBox.Text = this.drUsuarioLocaSMS.Login;
                this.SenhatextBox.Text = this.drUsuarioLocaSMS.Senha;
                this.SaldonumericTextBox.Value = this.drUsuarioLocaSMS.Saldo;
                this.DataCadastrodateTimePicker.Value = this.drUsuarioLocaSMS.DataCadastro;
                this.BloqueadocheckBox.Checked = this.drUsuarioLocaSMS.Bloqueado;

                this.drUsuarioLocaSMS.BeginEdit();
            }

            this.DescricaotextBox.Focus();
        }

        public override void Gravar( object sender, EventArgs e )
        {
            base.Gravar( sender, e );

            try
            {
                if ( this.DescricaotextBox.Text.Vazio() )
                {
                    AppUtil.MensagemAviso( "Informe a Descrição!" );

                    this.DescricaotextBox.Focus();

                    return;
                }

                if ( this.LogintextBox.Text.Vazio() )
                {
                    AppUtil.MensagemAviso( "Informe o login!" );

                    this.LogintextBox.Focus();

                    return;
                }

                if ( this.SenhatextBox.Text.Vazio() )
                {
                    AppUtil.MensagemAviso( "Informe a Senha!" );

                    this.SenhatextBox.Focus();

                    return;
                }

                DialogResult dialog = AppUtil.MensagemDialogo( "Deseja incluír esse usuário?" );

                if ( dialog != DialogResult.Yes )
                    return;

                this.drUsuarioLocaSMS.Descricao = this.DescricaotextBox.Text;
                this.drUsuarioLocaSMS.Login = this.LogintextBox.Text;
                this.drUsuarioLocaSMS.Senha = this.SenhatextBox.Text;
                this.drUsuarioLocaSMS.Bloqueado = this.BloqueadocheckBox.Checked;
                this.drUsuarioLocaSMS.Saldo = this.SaldonumericTextBox.Value;

                if ( this.drUsuarioLocaSMS.RowState == DataRowState.Detached )
                {
                    this.drUsuarioLocaSMS.DataCadastro = this.DataCadastrodateTimePicker.Value;

                    this.usuarioLocaSMSDataSet.UsuariosLocaSMS.AddUsuariosLocaSMSRow( this.drUsuarioLocaSMS );
                }
                else
                {
                    this.drUsuarioLocaSMS.DataAlteracao = DateTime.Now;

                    this.drUsuarioLocaSMS.EndEdit();
                }

                string retorno = UsuarioLocaSMSController.SetUpdate( this.usuarioLocaSMSDataSet );

                if ( retorno != string.Empty )
                    throw new Exception( retorno );

                AppUtil.MensagemSucesso( "Usuário LocaSMS salvo com sucesso!" );

                this.Close();
                this.oViewer.Atualizar( sender, e );

            }
            catch ( Exception ex )
            {

                AppUtil.MensagemErro( ex );
            }
        }

        private void LogintextBox_KeyPress( object sender, KeyPressEventArgs e )
        {
            e.Handled = AppUtil.AceitaNumero( e.KeyChar );
        }

        private void SenhatextBox_KeyPress( object sender, KeyPressEventArgs e )
        {
            e.Handled = AppUtil.AceitaNumero( e.KeyChar );
        }
    }
}
