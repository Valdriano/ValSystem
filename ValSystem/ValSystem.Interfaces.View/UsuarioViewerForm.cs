using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ValSystem.Interfaces.Controller;
using ValSystem.Interfaces.Model;
using ValSystem.Model;
using ValSystem.Util;

namespace ValSystem.Interfaces.View
{
    public partial class UsuarioViewerForm : ValSystem.View.DataViewerForm
    {
        public UsuarioViewerForm()
        {
            InitializeComponent();

            this.Janela_IDModulo = "1";
            this.Janela_Modulo = "Configurações do Sistema";
            this.Janela_IDModuloItem = "10";
            this.Janela_ModuloItem = "Cadastros";
            this.Janela_IDRotina = "101";
            this.Janela_Rotina = "Usuários";
            this.Janela_RotinaItem = new List<string>();

            this.Janela_RotinaItem.Add( "1 - Gravar" );
        }

        private void UsuarioViewerForm_Shown( object sender, EventArgs e )
        {
            this.ExibirOpcoes( true, true, true );

            this.Atualizar( sender, e );
        }

        public override void Atualizar( object sender, EventArgs e )
        {
            base.Atualizar( sender, e );

            Application.DoEvents();
            Cursor.Current = Cursors.WaitCursor;

            this.frmApp.Mensagem_Status( "Carregando Registros, por favor aguarde..." );

            int position = this.bindingSourceViewer.Position;

            this.usuarioDataSet.Consulta.Clear();
            this.usuarioDataSet.Consulta.Merge( UsuarioController.GetConsulta() );

            this.bindingSourceViewer.Position = position;

            Cursor.Current = Cursors.Default;
            this.frmApp.Mensagem_Status();
        }

        public override void Incluir( object sender, EventArgs e )
        {
            base.Incluir( sender, e );

            UsuarioEditForm oEdit = new UsuarioEditForm( this, -1 );

            oEdit.AppForm = this.frmApp;
            oEdit.Show();

        }

        public override void Editar( object sender, EventArgs e )
        {
            base.Editar( sender, e );

            if ( this.bindingSourceViewer.Count > 0 )
            {
                UsuarioDataSet.ConsultaRow dr = ( ( DataRowView )this.bindingSourceViewer.Current ).Row as UsuarioDataSet.ConsultaRow;

                UsuarioEditForm oEdit = new UsuarioEditForm( this, Convert.ToInt32( dr.Id ) );

                oEdit.AppForm = this.frmApp;
                oEdit.Show();
            }
        }

        public override void Excluir( object sender, EventArgs e )
        {
            base.Excluir( sender, e );

            try
            {
                if ( this.bindingSourceViewer.Count > 0 )
                {
                    UsuarioDataSet.ConsultaRow dr = ( ( DataRowView )this.bindingSourceViewer.Current ).Row as UsuarioDataSet.ConsultaRow;

                    DialogResult dialog = AppUtil.MensagemDialogo( $"Deseja excluir o usuário: {dr.Id} - {dr.Descricao} ?" );

                    if ( dialog != DialogResult.Yes )
                        return;

                    string retorno = UsuarioController.Excluir( Convert.ToInt32( dr.Id ) );

                    if ( retorno != string.Empty )
                        throw new Exception( retorno );


                    AppUtil.MensagemSucesso( $"Usuário: {dr.Id} - {dr.Descricao}\nExcluído com sucesso" );

                    this.Atualizar( sender, e );
                }
            }
            catch ( Exception ex )
            {

                AppUtil.MensagemErro( ex );
            }
        }

        private void dataGridView1_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            this.Editar( sender, new EventArgs() );
        }
    }
}
