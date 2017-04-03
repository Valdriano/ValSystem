using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValSystem.Interfaces.Controller;
using ValSystem.Interfaces.Model;
using ValSystem.Util;

namespace ValSystem.Interfaces.View
{
    public partial class UsuarioEditForm : ValSystem.View.DataEditForm
    {
        protected int Id;
        protected UsuarioDataSet.UsuariosRow drUsuario;
        protected UsuarioViewerForm oViewer;
        public UsuarioEditForm( UsuarioViewerForm oViewer, int Id )
        {
            InitializeComponent();

            this.oViewer = oViewer;
            this.Id = Id;
        }

        private void UsuarioEditForm_Shown( object sender, EventArgs e )
        {
            this.usuarioDataSet.Clear();
            this.usuarioDataSet.Usuarios.Merge( UsuarioController.GetUsuario( this.Id ) );

            if ( this.usuarioDataSet.Usuarios != null && this.usuarioDataSet.Usuarios.Count > 0 )
            {
                this.drUsuario = this.usuarioDataSet.Usuarios[ 0 ];

                this.IdUsuariotextBox.Text = this.drUsuario.Id.ToString();
                this.UsuariotextBox.Text = this.drUsuario.Descricao;
                this.SenhatextBox.Text = this.drUsuario.Senha;
                this.BloqueadocheckBox.Checked = this.drUsuario.Bloqueado;
                this.IdPerfiltextBox.Text = this.drUsuario.IdPerfil.ToString();
                this.IdPerfiltextBox_Leave( sender, e );

                this.drUsuario.BeginEdit();
            }
            else
            {
                this.drUsuario = this.usuarioDataSet.Usuarios.NewUsuariosRow();
            }

            this.UsuariotextBox.Focus();

        }

        private void IdPerfiltextBox_KeyPress( object sender, KeyPressEventArgs e )
        {
            e.Handled = AppUtil.AceitaNumero( e.KeyChar );
        }

        private void IdPerfiltextBox_Leave( object sender, EventArgs e )
        {
            if ( !this.IdPerfiltextBox.Text.Vazio() )
            {
                this.usuarioDataSet.Perfis.Clear();
                this.usuarioDataSet.Perfis.Merge( UsuarioController.GetPerfil( Convert.ToInt32( this.IdPerfiltextBox.Text ) ) );

                if ( this.usuarioDataSet.Perfis.Count == 0 )
                {
                    MessageBox.Show( "Perfil não localizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning );

                    this.IdPerfiltextBox.Focus();
                    this.PerfiltextBox.Clear();

                    return;
                }
                else
                {
                    this.PerfiltextBox.Text = this.usuarioDataSet.Perfis[ 0 ].Descricao;
                }
            }
            else
            {
                this.PerfiltextBox.Clear();
            }
        }

        public override void Gravar( object sender, EventArgs e )
        {
            base.Gravar( sender, e );

            try
            {
                if ( this.UsuariotextBox.Text.Vazio() )
                {
                    AppUtil.MensagemAviso( "Informe o nome do usuário!" );

                    this.UsuariotextBox.Focus();

                    return;
                }

                if ( this.SenhatextBox.Text.Vazio() )
                {
                    AppUtil.MensagemAviso( "Informe a senha!" );

                    this.SenhatextBox.Focus();

                    return;
                }

                if ( this.IdPerfiltextBox.Text.Vazio() )
                {
                    AppUtil.MensagemAviso( "Informe o perfil!" );

                    this.IdPerfiltextBox.Focus();

                    return;
                }

                this.drUsuario.Bloqueado = this.BloqueadocheckBox.Checked;
                this.drUsuario.Descricao = this.UsuariotextBox.Text;
                this.drUsuario.IdPerfil = Convert.ToInt32( this.IdPerfiltextBox.Text );
                this.drUsuario.Senha = this.SenhatextBox.Text;

                if ( this.drUsuario.RowState == DataRowState.Detached )
                {
                    this.usuarioDataSet.Usuarios.AddUsuariosRow( this.drUsuario );
                }
                else
                {
                    this.drUsuario.EndEdit();
                }

                string retorno = UsuarioController.SetUpdate( this.usuarioDataSet );

                if ( retorno != string.Empty )
                    throw new Exception( retorno );
                else
                {
                    AppUtil.MensagemSucesso( $"Usuario: {this.drUsuario.Id} - {this.drUsuario.Descricao} \nSalvo com sucesso!" );

                    this.Close();

                    this.oViewer.Atualizar( sender, e );
                }
            }
            catch ( Exception ex )
            {

                AppUtil.MensagemErro( ex );
            }
        }
    }
}
