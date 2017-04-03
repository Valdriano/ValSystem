using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            this.MenutreeView.Nodes.Clear();
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

        public override void RecarregarMenu( int IdUsuario, int IdPerfil )
        {
            this.CarregarMenuTreeView( IdUsuario, IdPerfil );
        }

        private void Pesquisatstb_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == ( char )Keys.Enter )
            {
                if ( AppUtil.Vazio( this.Pesquisatstb.Text ) )
                {
                    RecarregarMenu( 1, 1 );
                }
                else
                {
                    this.MenutreeView.CollapseAll();

                    if ( this.Pesquisatstb.Text.Trim().Length < 3 )
                    {
                        this.Pesquisatstb.Focus();
                        this.Pesquisatstb.SelectAll();

                        MessageBox.Show( this, "ATENÇÃO:\n\n" + "Em sua pesquisa deve conter mínimo 3 caracteres.", "Localizar Rotina", MessageBoxButtons.OK, MessageBoxIcon.Stop );

                        return;
                    }

                    if ( AppUtil.Enumero( this.Pesquisatstb.Text.Trim() ) && this.Pesquisatstb.Text.Length < 3 )
                    {
                        this.Pesquisatstb.Focus();
                        this.Pesquisatstb.SelectAll();

                        return;
                    }

                    if ( AppUtil.Enumero( this.Pesquisatstb.Text.Trim() ) )
                    {
                        this.BuscarRotina( this.Pesquisatstb.Text.Trim(), this.MenutreeView.Nodes );
                    }
                    else
                    {
                        TreeNode nodesLoc = MenuController.LocalizadorRotinas( this.Pesquisatstb.Text.Trim() );

                        if ( nodesLoc != null && nodesLoc.Nodes.Count > 0 )
                        {
                            this.MenutreeView.Nodes.Insert( 0, nodesLoc );
                        }
                    }
                }
            }
        }

        private void BuscarRotina( string texto, TreeNodeCollection collection )
        {
            int i = 0;
            int index = -1;

            foreach ( TreeNode tree in collection )
            {
                //utilizando a recursividade
                this.BuscarRotina( texto, tree.Nodes );
                //faz a busca por trecho de texto
                index = tree.Text.IndexOf( texto, StringComparison.OrdinalIgnoreCase );

                if ( index > -1 )
                {
                    if ( tree.Parent == null ) //se não tiver parent (caso do 1º nivel)
                    {
                        this.MenutreeView.SelectedNode = tree; //expande o nivel anterior
                        this.MenutreeView.SelectedNode.Expand();
                    }
                    else
                    {
                        this.MenutreeView.SelectedNode = tree; //expande o nivel anterior
                        this.MenutreeView.SelectedNode.ForeColor = Color.Blue;
                        this.MenutreeView.SelectedNode.Parent.Expand();

                        if ( index == 0 )
                        {
                            this.MenutreeView_DoubleClick( this.MenutreeView, EventArgs.Empty );
                        }
                    }
                }

                i++;
            }
        }

        private void BuscarGuiaRotina( string texto, TreeNodeCollection collection )
        {
            IEnumerable<TreeNode> childNodes = collection.Cast<TreeNode>().Where( w => w.Tag != null );

            foreach ( TreeNode node in childNodes )
            {
                IEnumerable<TreeNode> childNodes2 = collection.Cast<TreeNode>().Where( w => w.Tag != null );

                foreach ( TreeNode node2 in childNodes2 )
                {
                    IEnumerable<TreeNode> childNodes3 = collection.Cast<TreeNode>().Where( w => w.Tag != null );

                    foreach ( TreeNode node3 in childNodes3 )
                    {
                        if ( AppUtil.Enumero( texto ) )
                        {
                            if ( node2.Text.Contains( texto ) )
                            {
                                this.MenutreeView.SelectedNode = node2;
                                this.MenutreeView.SelectedNode.ForeColor = Color.Blue;

                                this.MenutreeView_DoubleClick( this.MenutreeView, new EventArgs() );

                                return;
                            }
                        }
                        else
                        {
                            if ( node2.Text.IndexOf( texto, StringComparison.OrdinalIgnoreCase ) > -1 )
                            {
                                this.MenutreeView.SelectedNode = node2;
                                this.MenutreeView.ForeColor = Color.Blue;
                                this.MenutreeView.SelectedNode.Parent.Expand();
                            }
                        }
                    }
                }
            }
        }

        private void menuDoSistemaToolStripMenuItem_Click( object sender, EventArgs e )
        {
            MenuToolForm oForm = new MenuToolForm();

            oForm.AppForm = this;
            oForm.Show();
        }

        private void reiniciarToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Application.Restart();
        }
    }
}
