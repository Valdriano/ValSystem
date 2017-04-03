using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValSystem.Interfaces.Controller;
using ValSystem.Interfaces.Model;
using ValSystem.Util;

namespace ValSystem.Interfaces.View
{
    public partial class PerfilEditForm : ValSystem.View.DataEditForm
    {
        protected int Id;
        protected PerfilViewerForm oViewer;
        protected PerfilDataSet.PerfisRow drPerfil;

        public PerfilEditForm( PerfilViewerForm oViewer, int Id )
        {
            InitializeComponent();

            this.Id = Id;
            this.oViewer = oViewer;
        }

        private void PerfilEditForm_Shown( object sender, EventArgs e )
        {
            this.perfilDataSet.Perfis.Clear();
            this.perfilDataSet.Perfis.Merge( PerfilController.GetPerfil( this.Id ) );

            if ( this.perfilDataSet.Perfis.Count <= 0 )
            {
                this.drPerfil = this.perfilDataSet.Perfis.NewPerfisRow();
            }
            else
            {
                this.drPerfil = this.perfilDataSet.Perfis[ 0 ];

                this.IdtextBox.Text = this.drPerfil.Id.ToString();
                this.DescricaotextBox.Text = this.drPerfil.Descricao;

                this.drPerfil.BeginEdit();
            }

            this.DescricaotextBox.Focus();
        }

        public override void Gravar( object sender, EventArgs e )
        {
            base.Gravar( sender, e );

            try
            {
                if ( this.DescricaotextBox.Text.Vazio() )
                {
                    AppUtil.MensagemAviso( "Informe a Descrição" );

                    this.DescricaotextBox.Focus();

                    return;
                }

                this.drPerfil.Descricao = this.DescricaotextBox.Text;

                if ( this.drPerfil.RowState == DataRowState.Detached )
                {
                    this.perfilDataSet.Perfis.AddPerfisRow( this.drPerfil );
                }
                else
                {
                    this.drPerfil.EndEdit();
                }

                string ret = PerfilController.SetUpdate( this.perfilDataSet );

                if ( ret != string.Empty )
                    throw new Exception( ret );
                else
                {
                    AppUtil.MensagemSucesso( "Perfil salvo com sucesso!" );

                    this.Close();
                    this.oViewer.Atualizar( sender, e );
                }
            }
            catch ( Exception ex )
            {

                AppUtil.MensagemErro( ex );
            }
        }
    }
}
