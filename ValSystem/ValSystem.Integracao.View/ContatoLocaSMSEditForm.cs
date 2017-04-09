using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValSystem.Integracao.Controller;
using ValSystem.Integracao.Model;
using ValSystem.Util;

namespace ValSystem.Integracao.View
{
    public partial class ContatoLocaSMSEditForm : ValSystem.View.DataEditForm
    {
        protected int Id;
        protected ContatoLocaSMSViewerForm oViewer;
        protected ContatoLocaSMSDataSet.ContatosLocaSMSRow drContatoLocaSMS;
        public ContatoLocaSMSEditForm( int Id, ContatoLocaSMSViewerForm oViewer )
        {
            InitializeComponent();

            this.Id = Id;
            this.oViewer = oViewer;
        }

        private void ContatoLocaSMSEditForm_Shown( object sender, EventArgs e )
        {
            this.contatoLocaSMSDataSet.ContatosLocaSMS.Clear();
            this.contatoLocaSMSDataSet.ContatosLocaSMS.Merge( ContatoLocaSMSController.GetContato( this.Id ) );

            if ( this.contatoLocaSMSDataSet.ContatosLocaSMS.Count <= 0 )
            {
                this.drContatoLocaSMS = this.contatoLocaSMSDataSet.ContatosLocaSMS.NewContatosLocaSMSRow();
            }
            else
            {
                this.drContatoLocaSMS = this.contatoLocaSMSDataSet.ContatosLocaSMS[ 0 ];

                this.IdtextBox.Text = this.drContatoLocaSMS.Id.ToString();
                this.DataCadastrodateTimePicker.Value = this.drContatoLocaSMS.DataCadastro;
                this.NometextBox.Text = this.drContatoLocaSMS.Nome;
                this.CEPmaskedTextBox.Text = this.drContatoLocaSMS.Cep;
                this.UFcomboBox.SelectedValue = this.drContatoLocaSMS.UF;
                this.BairrotextBox.Text = this.drContatoLocaSMS.Bairro;
                this.EnderecotextBox.Text = this.drContatoLocaSMS.Endereco;
                this.NumerotextBox.Text = this.drContatoLocaSMS.Numero;
                this.ComplementotextBox.Text = this.drContatoLocaSMS.Complemento;

                if ( !this.drContatoLocaSMS.IsDDDNull() )
                    this.DDDtextBox.Text = this.drContatoLocaSMS.DDD.ToString();

                if ( !this.drContatoLocaSMS.IsTelefoneNull() )
                    this.TelefonemaskedTextBox.Text = this.drContatoLocaSMS.Telefone.ToString();

                if ( !this.drContatoLocaSMS.IsCelular1Null() )
                    this.Celular1maskedTextBox.Text = this.drContatoLocaSMS.Celular1.ToString();

                if ( !this.drContatoLocaSMS.IsCelular2Null() )
                    this.Celular2maskedTextBox.Text = this.drContatoLocaSMS.Celular2.ToString();

                if ( !this.drContatoLocaSMS.IsCelular3Null() )
                    this.Celular3maskedTextBox.Text = this.drContatoLocaSMS.Celular3.ToString();

                if ( !this.drContatoLocaSMS.IsCelular4Null() )
                    this.Celular4maskedTextBox.Text = this.drContatoLocaSMS.Celular4.ToString();

                this.drContatoLocaSMS.BeginEdit();
            }

            this.NometextBox.Focus();
        }

        private void DDDtextBox_KeyPress( object sender, KeyPressEventArgs e )
        {
            e.Handled = AppUtil.AceitaNumero( e.KeyChar );
        }

        public override void Gravar( object sender, EventArgs e )
        {
            base.Gravar( sender, e );

            try
            {
                if ( this.NometextBox.Text.Vazio() )
                {
                    AppUtil.MensagemAviso( "Informe o Nome!" );

                    this.NometextBox.Focus();

                    return;
                }

                //if ( !( this.TelefonemaskedTextBox.Text.Replace( "-", null ).Vazio() || this.Celular1maskedTextBox.Text.Replace( "-", null ).Vazio() ||
                //     this.Celular2maskedTextBox.Text.Replace( "-", null ).Vazio() || this.Celular3maskedTextBox.Text.Replace( "-", null ).Vazio() || this.Celular4maskedTextBox.Text.Replace( "-", null ).Vazio() ) )
                //{
                //    AppUtil.MensagemAviso( "Informe pelo menos um numero de contato!" );

                //    return;
                //}

                this.drContatoLocaSMS.Bairro = this.BairrotextBox.Text;

                if ( !this.Celular1maskedTextBox.Text.Replace( "-", null ).RemoveEspaco().Vazio() )
                    this.drContatoLocaSMS.Celular1 = Convert.ToInt32( this.Celular1maskedTextBox.Text.Replace( "-", null ).RemoveEspaco() );

                if ( !this.Celular2maskedTextBox.Text.Replace( "-", null ).Vazio() )
                    this.drContatoLocaSMS.Celular2 = Convert.ToInt32( this.Celular2maskedTextBox.Text.Replace( "-", null ).RemoveEspaco() );

                if ( !this.Celular3maskedTextBox.Text.Replace( "-", null ).Vazio() )
                    this.drContatoLocaSMS.Celular3 = Convert.ToInt32( this.Celular3maskedTextBox.Text.Replace( "-", null ).RemoveEspaco() );

                if ( !this.Celular4maskedTextBox.Text.Replace( "-", null ).Vazio() )
                    this.drContatoLocaSMS.Celular4 = Convert.ToInt32( this.Celular4maskedTextBox.Text.Replace( "-", null ).RemoveEspaco() );

                this.drContatoLocaSMS.Cep = this.CEPmaskedTextBox.Text;
                this.drContatoLocaSMS.Cidade = this.CidadetextBox.Text;
                this.drContatoLocaSMS.Complemento = this.ComplementotextBox.Text;

                if ( !this.DDDtextBox.Text.Vazio() )
                    this.drContatoLocaSMS.DDD = Convert.ToInt16( this.DDDtextBox.Text );

                this.drContatoLocaSMS.Email = "";
                this.drContatoLocaSMS.Endereco = this.EnderecotextBox.Text;
                this.drContatoLocaSMS.Estado = this.EstadotextBox.Text;
                this.drContatoLocaSMS.Nome = this.NometextBox.Text;
                this.drContatoLocaSMS.Numero = this.NumerotextBox.Text;

                if ( !this.TelefonemaskedTextBox.Text.Replace( "-", null ).RemoveEspaco().Vazio() )
                    this.drContatoLocaSMS.Telefone = Convert.ToInt32( this.TelefonemaskedTextBox.Text.Replace( "-", null ).RemoveEspaco() );

                this.drContatoLocaSMS.UF = Convert.ToString( this.UFcomboBox.SelectedValue );

                if ( this.drContatoLocaSMS.RowState == DataRowState.Detached )
                {
                    this.drContatoLocaSMS.DataCadastro = this.DataCadastrodateTimePicker.Value;

                    this.contatoLocaSMSDataSet.ContatosLocaSMS.AddContatosLocaSMSRow( this.drContatoLocaSMS );
                }
                else
                {
                    this.drContatoLocaSMS.DataAlteracao = DateTime.Now;

                    this.drContatoLocaSMS.EndEdit();
                }

                string retorno = ContatoLocaSMSController.SetUpdate( this.contatoLocaSMSDataSet );

                if ( retorno != string.Empty )
                    throw new Exception( retorno );

                AppUtil.MensagemSucesso( "Contato Salvo com sucesso!" );

                this.Close();
                this.oViewer.Atualizar( sender, e );
            }
            catch ( Exception ex )
            {
                AppUtil.MensagemErro( ex );
            }
        }
    }
}
