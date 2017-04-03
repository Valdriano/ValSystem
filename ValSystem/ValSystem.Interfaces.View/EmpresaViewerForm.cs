using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValSystem.Interfaces.Controller;

namespace ValSystem.Interfaces.View
{
    public partial class EmpresaViewerForm : ValSystem.View.DataViewerForm
    {
        public EmpresaViewerForm()
        {
            InitializeComponent();

            this.Janela_IDModulo = "1";
            this.Janela_Modulo = "Configurações do Sistema";
            this.Janela_IDModuloItem = "10";
            this.Janela_ModuloItem = "Cadastros";
            this.Janela_IDRotina = "103";
            this.Janela_Rotina = "Empresas";
            this.Janela_RotinaItem = new List<string>();

            this.Janela_RotinaItem.Add( "1 - Gravar" );
        }

        private void EmpresaViewerForm_Shown( object sender, EventArgs e )
        {
            this.Atualizar( sender, e );
        }

        public override void Atualizar( object sender, EventArgs e )
        {
            base.Atualizar( sender, e );

            Application.DoEvents();
            Cursor.Current = Cursors.WaitCursor;

            this.frmApp.Mensagem_Status( "Carregando Registros, por favor aguarde..." );

            int position = this.bindingSourceViewer.Position;

            this.empresaDataSet.Empresas.Clear();
            this.empresaDataSet.Empresas.Merge( EmpresaController.GetEmpresas() );

            if ( position != -1 )
            {
                this.bindingSourceViewer.Position = position;
            }
            else
            {
                this.bindingSourceViewer.MoveLast();
            }

            Cursor.Current = Cursors.Default;

            this.frmApp.Mensagem_Status();
        }
    }
}
