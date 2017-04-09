using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValSystem.Integracao.Controller;
using ValSystem.Util;

namespace ValSystem.Integracao.View
{
    public partial class ContatoLocaSMSImportarToolForm : ValSystem.View.ToolForm
    {
        public ContatoLocaSMSImportarToolForm()
        {
            InitializeComponent();

            this.Janela_IDModulo = "10";
            this.Janela_Modulo = "Integração";
            this.Janela_IDModuloItem = "100";
            this.Janela_ModuloItem = "LocaSMS";
            this.Janela_IDRotina = "1002";
            this.Janela_Rotina = "Importar Contatos LocaSMS";
            this.Janela_RotinaItem = new List<string>();

            this.Janela_RotinaItem.Add( "1 - Executar" );
        }

        private void Diretoriobutton_Click( object sender, EventArgs e )
        {
            if ( this.openFileDialog.ShowDialog() != DialogResult.OK )
                return;

            this.DiretoriotextBox.Text = this.openFileDialog.FileName;
        }

        public override void Executar( object sender, EventArgs e )
        {
            base.Executar( sender, e );

            try
            {
                if ( this.DiretoriotextBox.Text.Vazio() )
                {
                    AppUtil.MensagemAviso( "Informe o diretorio!" );

                    this.Diretoriobutton.Focus();

                    return;
                }

                DialogResult dialog = AppUtil.MensagemDialogo( "Atenção deseja excuta essa operãção?" );

                if ( dialog != DialogResult.Yes )
                    return;

                Application.DoEvents();
                Cursor.Current = Cursors.WaitCursor;

                this.frmApp.Mensagem_Status( "Importando contatos, por favor aguarde..." );

                string retorno = ContatoLocaSMSController.ImportaContatosLocaSMS( false, this.openFileDialog.FileName );

                if ( retorno != string.Empty )
                    throw new Exception( retorno );

                AppUtil.MensagemSucesso( "Contatos importado com sucesso!" );

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
