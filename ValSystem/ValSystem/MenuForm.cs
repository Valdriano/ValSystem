using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValSystem.Controller;
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

        async void CarregarMenuTreeView( int IdUsuario, int IdPerfil )
        {
            MenuController menu = new MenuController();

            this.MenutreeView.Nodes.AddRange( await menu.CarregarMenuTreeNode( IdUsuario, IdPerfil ) );

        }

        private void MenutreeView_DoubleClick( object sender, EventArgs e )
        {
            if ( sender is TreeView )
            {
                Form oForm = new MenuController().CarregarRotina( ( TreeView )sender );

                if ( oForm != null )
                    oForm.Show();
            }
        }
    }
}
