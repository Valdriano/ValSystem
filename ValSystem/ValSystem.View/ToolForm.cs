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
    public partial class ToolForm : Form
    {
        protected AppForm frmApp;
        public string Janela_IDModulo { get; set; }
        public string Janela_Modulo { get; set; }
        public string Janela_IDModuloItem { get; set; }
        public string Janela_ModuloItem { get; set; }
        public string Janela_IDRotina { get; set; }
        public string Janela_Rotina { get; set; }
        public List<string> Janela_RotinaItem { get; set; }

        public ToolForm()
        {
            InitializeComponent();
        }

        public AppForm AppForm
        {
            get { return this.frmApp; }
            set { this.frmApp = value; this.MdiParent = value; }
        }

        private void ToolForm_Shown( object sender, EventArgs e )
        {
            this.ExibirOpcoes();
        }

        private void ToolForm_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == ( char )Keys.Enter )
            {
                this.ProcessTabKey( true );

                e.Handled = true;
            }
            else if ( e.KeyChar == ( char )Keys.Escape )
            {
                this.Close();

                e.Handled = true;
            }
        }

        private void ExecutartoolStripButton_Click( object sender, EventArgs e )
        {
            this.Executar( sender, e );
        }

        private void LocalizartoolStripButton_Click( object sender, EventArgs e )
        {
            this.Localizar( sender, e );
        }

        private void FechartoolStripButton_Click( object sender, EventArgs e )
        {
            this.Fechar( sender, e );
        }

        public virtual void Executar( object sender, EventArgs e )
        { }

        public virtual void Localizar( object sender, EventArgs e )
        { }

        public virtual void Fechar( object sender, EventArgs e )
        {
            this.Close();
        }

        public virtual void RecortarRegistro()
        {
            if ( this.ActiveControl is TextBoxBase && !( ( TextBoxBase )this.ActiveControl ).ReadOnly && this.ActiveControl.Enabled && !string.IsNullOrWhiteSpace( ( ( TextBoxBase )this.ActiveControl ).Text ) )
            {
                Clipboard.SetText( this.ActiveControl.Text );

                this.ActiveControl.Text = null;
            }
        }

        public virtual void CopiarRegistro()
        {
            if ( this.ActiveControl is TextBoxBase && !string.IsNullOrWhiteSpace( ( ( TextBoxBase )this.ActiveControl ).Text ) )
            {
                if ( ( ( TextBoxBase )this.ActiveControl ).SelectionLength > 0 )
                {
                    Clipboard.SetData( DataFormats.Text, ( ( TextBoxBase )this.ActiveControl ).SelectedText );
                }
            }
        }

        public virtual void ColarRegistro()
        {
            if ( this.ActiveControl is TextBoxBase && !( ( TextBoxBase )this.ActiveControl ).ReadOnly && this.ActiveControl.Enabled )
            {
                this.ActiveControl.Text += Clipboard.GetText();

                ( ( TextBoxBase )this.ActiveControl ).Select( ( ( TextBoxBase )this.ActiveControl ).Text.Length, 0 );
            }
        }

        public void ExibirOpcoes( bool executar = true, bool localizar = false, bool fechar = true )
        {
            this.ExecutartoolStripButton.Visible = executar;
            this.LocalizartoolStripButton.Visible = localizar;
            this.FechartoolStripButton.Visible = fechar;
        }

        public void BloquearMenu( bool valor = false )
        {
            this.toolStrip1.Enabled = !valor;
        }
    }
}
