using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValSystem.View
{
    public partial class DataViewerForm : Form
    {
        protected AppForm frmApp;
        public string Janela_IDModulo { get; set; }
        public string Janela_Modulo { get; set; }
        public string Janela_IDModuloItem { get; set; }
        public string Janela_ModuloItem { get; set; }
        public string Janela_IDRotina { get; set; }
        public string Janela_Rotina { get; set; }
        public List<string> Janela_RotinaItem { get; set; }

        public DataViewerForm()
        {
            InitializeComponent();
        }

        public AppForm AppForm
        {
            get { return this.frmApp; }
            set { this.frmApp = value; this.MdiParent = value; }
        }

        private void DataViewerForm_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == ( char )Keys.Escape )
            {
                this.Close();

                e.Handled = true;
            }
        }

        private void DataViewerForm_Shown( object sender, EventArgs e )
        {
            this.ExibirOpcoes();
            this.ExibirProgresso();
        }

        private void AdicionartoolStripButton_Click( object sender, EventArgs e )
        {
            this.Incluir( sender, e );
        }

        private void EditartoolStripButton_Click( object sender, EventArgs e )
        {
            this.Editar( sender, e );
        }

        private void ExcluirtoolStripButton_Click( object sender, EventArgs e )
        {
            this.Excluir( sender, e );
        }

        private void ImprimirtoolStripButton_Click( object sender, EventArgs e )
        {
            this.Imprimir( sender, e );
        }

        private void LocalizartoolStripButton_Click( object sender, EventArgs e )
        {
            this.Localizar( sender, e );
        }

        private void AtualizartoolStripButton_Click( object sender, EventArgs e )
        {
            this.Atualizar( sender, e );
        }

        private void MoveFirsttoolStripButton_Click( object sender, EventArgs e )
        {
            this.ViewerbindingSource.MoveFirst();
        }

        private void MoveLasttoolStripButton_Click( object sender, EventArgs e )
        {
            this.ViewerbindingSource.MoveLast();
        }

        private void FechartoolStripButton_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        public void ExibirOpcoes( bool incluir = true, bool editar = true, bool excluir = false, bool imprimir = false, bool localizar = true, bool atualizar = true, bool movePrimeiro = true, bool moveUltimo = true, bool fechar = true )
        {
            this.AdicionartoolStripButton.Visible = incluir;
            this.EditartoolStripButton.Visible = editar;
            this.ExcluirtoolStripButton.Visible = excluir;
            this.ImprimirtoolStripButton.Visible = imprimir;
            this.LocalizartoolStripButton.Visible = localizar;
            this.AtualizartoolStripButton.Visible = atualizar;
            this.MoveFirsttoolStripButton.Visible = movePrimeiro;
            this.MoveLasttoolStripButton.Visible = moveUltimo;
            this.FechartoolStripButton.Visible = fechar;
        }

        public void ExibirProgresso( bool exibir = false )
        {
            this.Progressotsspb.Visible = exibir;
            this.Porcentagemtssl.Visible = exibir;
        }

        public virtual void Incluir( object sender, EventArgs e )
        { }

        public virtual void Editar( object sender, EventArgs e )
        { }

        public virtual void Excluir( object sender, EventArgs e )
        { }

        public virtual void Imprimir( object sender, EventArgs e )
        { }

        public virtual void Localizar( object sender, EventArgs e )
        { }

        public virtual void Atualizar( object sender, EventArgs e )
        { }

        public virtual void Fechar( object sender, EventArgs e )
        { }
    }
}
