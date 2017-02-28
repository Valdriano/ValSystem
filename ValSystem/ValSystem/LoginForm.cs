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

                if ( !File.Exists( AppDomain.CurrentDomain.BaseDirectory + @"ValSystemDB.mdb" ) )
                {
                    DialogResult dialog = MessageBox.Show( this, "Atenção\n\nBase de Dados não encontrada!\nDeseja recriar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question );

                    if ( dialog != DialogResult.Yes )
                        return;
                    else
                    {
                        //
                    }
                }
                else
                {
                    JetEntityFrameworkProvider.JetConnection.ShowSqlStatements = true;

                    using ( var context = new AppController() )
                    {
                        Perfil per = new Perfil { Descricao = "Administrador" };

                        context.Perfis.Add( per );
                        context.SaveChanges();

                        Usuario usuario = new Usuario { Bloqueado = false, Descricao = "SUPERVISOR", IdPerfil = 1, Senha = "SELVA406" };

                        context.Usuarios.Add( usuario );
                        context.SaveChanges();

                    }
                }
            }
            catch ( Exception ex )
            {

                MessageBox.Show( this, $"Erro:\n\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1 );
            }
        }
    }
}
