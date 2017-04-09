using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValSystem.Interfaces.Controller;
using ValSystem.Interfaces.Model;

namespace ValSystem.Interfaces.View
{
    public partial class EmpresaEditForm : ValSystem.View.DataEditForm
    {
        protected int IdEmpresa;
        protected EmpresaViewerForm oViewer;
        protected EmpresaDataSet.EmpresasRow drEmpresa;
        public EmpresaEditForm( int IdEmpresa, EmpresaViewerForm oViewer )
        {
            InitializeComponent();

            this.IdEmpresa = IdEmpresa;
            this.oViewer = oViewer;
        }

        private void EmpresaEditForm_Shown( object sender, EventArgs e )
        {
            this.empresaDataSet.Empresas.Clear();
            this.empresaDataSet.Empresas.Merge( EmpresaController.GetEmpresa( this.IdEmpresa ) );

            if ( this.empresaDataSet.Empresas.Count <= 0 )
            {
                this.drEmpresa = this.empresaDataSet.Empresas.NewEmpresasRow();
            }
            else
            {
                this.drEmpresa = this.empresaDataSet.Empresas[ 0 ];

                this.CodigotextBox.Text = this.drEmpresa.Codigo;
                this.DataCadastrodateTimePicker.Value = this.drEmpresa.DataCadastro;
                this.RazaoSocialtextBox.Text = this.drEmpresa.RazaoSocial;
                this.FantasiatextBox.Text = this.drEmpresa.Fantasia;
                this.CNPJmaskedTextBox.Text = this.drEmpresa.CNPJ;
                this.PaiscomboBox.SelectedValue = this.drEmpresa.Pais;
                this.UFcomboBox.SelectedValue = this.drEmpresa.UF;
                this.EstadocomboBox.SelectedValue = this.drEmpresa.Estado;
                this.CEPmaskedTextBox.Text = this.drEmpresa.Cep;
                this.TelefonemaskedTextBox.Text = this.drEmpresa.Telefones;
                this.EnderecotextBox.Text = this.drEmpresa.Endereco;
                this.NumerotextBox.Text = this.drEmpresa.Numero;
                this.BairrotextBox.Text = this.drEmpresa.Bairro;
                this.ComplementotextBox.Text = this.drEmpresa.Complemento;
                this.EmailtextBox.Text = this.drEmpresa.Email;
                this.WebSitetextBox.Text = this.drEmpresa.WebSite;

                this.drEmpresa.BeginEdit();
            }

            this.RazaoSocialtextBox.Focus();
        }
    }
}
