using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValSystem.Controller;
using ValSystem.Interfaces.View;
using ValSystem.Util;

namespace ValSystem
{
    public partial class MenuForm : ValSystem.View.AppForm
    {
        protected DataSet ds;
        public MenuForm( DataSet ds )
        {
            InitializeComponent();
        }

        private void MenuForm_Load( object sender, EventArgs e )
        {
            this.Pesquisatstb_Enter( sender, e );
            this.Pesquisatstb_Leave( sender, e );

            this.CarregarMenuTreeView( 1, 1 );
        }

        private void splitter2_SplitterMoved( object sender, SplitterEventArgs e )
        {
            this.Pesquisatstb.Size = new Size( this.splitter2.Location.X - 5, 23 );
        }

        private void sairToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }

        private void Pesquisatstb_Enter( object sender, EventArgs e )
        {
            this.Pesquisatstb.Clear();
            this.Pesquisatstb.Font = new Font( this.Pesquisatstb.Font, FontStyle.Regular );
            this.Pesquisatstb.ForeColor = Color.Black;
        }

        private void Pesquisatstb_Leave( object sender, EventArgs e )
        {
            if ( AppUtil.Vazio( this.Pesquisatstb.Text ) )
            {
                this.Pesquisatstb.Text = "Clique aqui para pesquisa sua rotina...";
                this.Pesquisatstb.Font = new Font( this.Pesquisatstb.Font, FontStyle.Italic );
                this.Pesquisatstb.ForeColor = Color.Silver;
            }
        }

        public async void CarregarMenuTreeView( int IdUsuario, int IdPerfil )
        {
            MenuController menu = new MenuController();

            this.MenutreeView.Nodes.AddRange( await menu.CarregarMenuTreeNode( IdUsuario, IdPerfil ) );

            if ( this.MenutreeView.Nodes.Count == 0 )
            {
                MenuToolForm oMenu = new MenuToolForm();

                oMenu.AppForm = this;
                oMenu.Show();
            }
        }

        private void MenutreeView_DoubleClick( object sender, EventArgs e )
        {
            try
            {
                if ( sender is TreeView )
                {
                    new MenuController().CarregarRotina( ( TreeView )sender, this );
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( this, $"Erro\n\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1 );
            }
        }
    }
}
