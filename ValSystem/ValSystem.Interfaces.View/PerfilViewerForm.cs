using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValSystem.Interfaces.Controller;
using ValSystem.Interfaces.Model;

namespace ValSystem.Interfaces.View
{
    public partial class PerfilViewerForm : ValSystem.View.DataViewerForm
    {
        public PerfilViewerForm()
        {
            InitializeComponent();

            this.Janela_IDModulo = "1";
            this.Janela_Modulo = "Configurações do Sistema";
            this.Janela_IDModuloItem = "10";
            this.Janela_ModuloItem = "Cadastros";
            this.Janela_IDRotina = "102";
            this.Janela_Rotina = "Perfis";
            this.Janela_RotinaItem = new List<string>();

            this.Janela_RotinaItem.Add( "1 - Gravar" );
        }

        private void PerfilViewerForm_Shown( object sender, EventArgs e )
        {
            this.Atualizar( sender, e );
        }

        public override void Atualizar( object sender, EventArgs e )
        {
            base.Atualizar( sender, e );

            Application.DoEvents();
            Cursor.Current = Cursors.WaitCursor;

            this.frmApp.Mensagem_Status( "Carregando registros, por favor aguarde..." );

            int position = this.bindingSourceViewer.Position;

            this.perfilDataSet.Perfis.Clear();
            this.perfilDataSet.Perfis.Merge( PerfilController.GetPerfil() );

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

        public override void Incluir( object sender, EventArgs e )
        {
            base.Incluir( sender, e );

            PerfilEditForm oEdit = new PerfilEditForm( this, -1 );

            oEdit.AppForm = this.frmApp;

            oEdit.Show();
        }

        public override void Editar( object sender, EventArgs e )
        {
            base.Editar( sender, e );

            if ( this.bindingSourceViewer.Count > 0 )
            {
                PerfilDataSet.PerfisRow dr = ( ( DataRowView )this.bindingSourceViewer.Current ).Row as PerfilDataSet.PerfisRow;

                PerfilEditForm oEdit = new PerfilEditForm( this, Convert.ToInt32( dr.Id ) );

                oEdit.AppForm = this.frmApp;

                oEdit.Show();
            }
        }

        private void dataGridView1_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            this.Editar( sender, new EventArgs() );
        }
    }
}
