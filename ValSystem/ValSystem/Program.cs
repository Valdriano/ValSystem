﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValSystem.Controller;
using ValSystem.Model;

namespace ValSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Configuration conf = ConfigurationManager.OpenExeConfiguration( ConfigurationUserLevel.None );

            string path = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= {AppDomain.CurrentDomain.BaseDirectory + "ValSystemDB.mdb"};Persist Security Info=False;Jet OLEDB:Database Password=selva406";

            conf.ConnectionStrings.ConnectionStrings[ 2 ].ConnectionString = path;
            conf.Save( ConfigurationSaveMode.Modified );

            ConfigurationManager.RefreshSection( "appSetting" );

            AppController context = new AppController();

            if ( context.Perfis.Where( w => w.Descricao == "ADMINISTRADOR" ).Count() == 0 )
            {
                context.Perfis.Add( new Perfil { Descricao = "ADMINISTRADOR" } );
                context.SaveChanges();
            }

            if ( context.Perfis.Where( w => w.Descricao == "USUÁRIO" ).Count() == 0 )
            {
                context.Perfis.Add( new Perfil { Descricao = "USUÁRIO" } );
                context.SaveChanges();
            }

            if ( context.Usuarios.Where( w => w.Descricao == "SUPERVISOR" ).Count() == 0 )
            {
                context.Usuarios.Add( new Usuario { Bloqueado = false, Descricao = "SUPERVISOR", IdPerfil = 1, Senha = "SELVA406" } );
                context.SaveChanges();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new LoginForm() );
        }
    }
}
