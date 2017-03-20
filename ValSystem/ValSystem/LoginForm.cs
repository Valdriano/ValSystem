using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValSystem.Controller;
using ValSystem.Model;
using ValSystem.Util;

namespace ValSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load( object sender, EventArgs e )
        {
            try
            {
                Version version = Assembly.GetEntryAssembly().GetName().Version;

                this.Versaotssl.Text = $"Versão: {version.Major}.{version.Minor}.{version.Build}.{version.Revision}";

                //if ( !File.Exists( AppDomain.CurrentDomain.BaseDirectory + @"ValSystemDB.mdb" ) )
                //{
                //    DialogResult dialog = MessageBox.Show( this, "Atenção\n\nBase de Dados não encontrada!\nDeseja recriar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question );

                //    if ( dialog != DialogResult.Yes )
                //        return;
                //    else
                //    {
                //        //
                //    }
                //}
                //else
                //{
                //    JetEntityFrameworkProvider.JetConnection.ShowSqlStatements = true;

                //    using ( var context = new AppController() )
                //    {
                //        Perfil per = new Perfil { Descricao = "Administrador" };

                //        context.Perfis.Add( per );
                //        context.SaveChanges();

                //        Usuario usuario = new Usuario { Bloqueado = false, Descricao = "SUPERVISOR", IdPerfil = 1, Senha = "SELVA406" };

                //        context.Usuarios.Add( usuario );
                //        context.SaveChanges();

                //    }
                //}
            }
            catch ( Exception ex )
            {

                MessageBox.Show( this, $"Erro:\n\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1 );
            }
        }

        private void OKbutton_Click( object sender, EventArgs e )
        {
            try
            {
                if ( AppUtil.Vazio( this.UsuariotextBox.Text.Trim() ) )
                {
                    MessageBox.Show( "Atenção\n\nInforme o Usuário.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning );

                    this.UsuariotextBox.Focus();

                    return;
                }

                if ( AppUtil.Vazio( this.SenhatextBox.Text.Trim() ) )
                {
                    MessageBox.Show( "Atenção\n\nInforme a Senha.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning );

                    this.SenhatextBox.Focus();

                    return;
                }

                Application.DoEvents();
                Cursor.Current = Cursors.WaitCursor;

                using ( AppDbContext context = new AppDbContext( "valsystemDb" ) )
                {
                    DataSet ds = new DataSet();
                    Usuario drUsuario = context.Set<Usuario>().Single( s => s.Descricao == this.UsuariotextBox.Text.Trim() && s.Senha == this.SenhatextBox.Text.Trim() );

                    if ( context.Set<Usuario>().Count() > 0 )
                    {
                        DataTable dtUsuarios = new DataTable( "Usuarios" );
                        DataColumn IdUsuario = new DataColumn { DataType = typeof( int ), ColumnName = "IdUsuario" };
                        DataColumn Descricao = new DataColumn { DataType = typeof( string ), ColumnName = "Descricao" };
                        DataColumn Bloqueado = new DataColumn { DataType = typeof( bool ), ColumnName = "Bloqueado" };
                        DataColumn IdPerfil = new DataColumn { DataType = typeof( int ), ColumnName = "IdPerfil" };
                        dtUsuarios.Columns.AddRange( new DataColumn[] { IdUsuario, Descricao, Bloqueado, IdPerfil } );

                        DataRow drUsr = dtUsuarios.NewRow();
                        drUsr[ IdUsuario ] = drUsuario.Id;
                        drUsr[ Descricao ] = drUsuario.Descricao;
                        drUsr[ Bloqueado ] = drUsuario.Bloqueado;
                        drUsr[ IdPerfil ] = drUsuario.IdPerfil;
                        dtUsuarios.Rows.Add( drUsr );

                        DataTable dt = new DataTable( "Configuracao" );
                        DataColumn VersaoColumn = new DataColumn { DataType = Type.GetType( "System.String" ), ColumnName = "Versao" };
                        dt.Columns.Add( VersaoColumn );

                        DataRow dr = dt.NewRow();
                        dr[ VersaoColumn ] = this.Versaotssl.Text;
                        dt.Rows.Add( dr );

                        ds.Tables.AddRange( new DataTable[] { dt, dtUsuarios } );

                        MenuForm oViewer = new MenuForm( ds );

                        oViewer.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show( "Atenção\n\nUsuário ou Senha incorreta!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning );

                        this.SenhatextBox.Focus();
                        this.SenhatextBox.Select( 0, this.SenhatextBox.Text.Length );

                        return;
                    }
                }
            }
            catch ( Exception ex )
            {

                MessageBox.Show( this, $"Erro:\n\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1 );
            }
        }

        private void Sairbutton_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }
    }
}
