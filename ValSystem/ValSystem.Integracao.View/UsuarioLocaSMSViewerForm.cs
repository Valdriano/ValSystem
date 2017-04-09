﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValSystem.Integracao.Controller;
using ValSystem.Integracao.Model;

namespace ValSystem.Integracao.View
{
    public partial class UsuarioLocaSMSViewerForm : ValSystem.View.DataViewerForm
    {
        public UsuarioLocaSMSViewerForm()
        {
            InitializeComponent();

            this.Janela_IDModulo = "10";
            this.Janela_Modulo = "Integração";
            this.Janela_IDModuloItem = "100";
            this.Janela_ModuloItem = "LocaSMS";
            this.Janela_IDRotina = "1000";
            this.Janela_Rotina = "Usuários LocaSMS";
            this.Janela_RotinaItem = new List<string>();

            this.Janela_RotinaItem.Add( "1 - Gravar" );
        }

        private void UsuarioLocaSMSViewerForm_Shown( object sender, EventArgs e )
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

            this.usuarioLocaSMSDataSet.UsuariosLocaSMS.Clear();
            this.usuarioLocaSMSDataSet.UsuariosLocaSMS.Merge( UsuarioLocaSMSController.GetUsuariosLocaSMS() );

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

            UsuarioLocaSMSEditForm oEdit = new UsuarioLocaSMSEditForm( -1, this );

            oEdit.AppForm = this.frmApp;
            oEdit.Show();
        }

        public override void Editar( object sender, EventArgs e )
        {
            base.Editar( sender, e );

            if ( this.bindingSourceViewer.Count > 0 )
            {
                UsuarioLocaSMSDataSet.UsuariosLocaSMSRow dr = ( ( DataRowView )this.bindingSourceViewer.Current ).Row as UsuarioLocaSMSDataSet.UsuariosLocaSMSRow;

                UsuarioLocaSMSEditForm oEdit = new UsuarioLocaSMSEditForm( Convert.ToInt32( dr.Id ), this );

                oEdit.AppForm = this.frmApp;
                oEdit.Show();
            }
        }
    }
}
