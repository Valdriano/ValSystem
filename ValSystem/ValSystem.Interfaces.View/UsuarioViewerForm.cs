using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ValSystem.Interfaces.View
{
    public partial class UsuarioViewerForm : ValSystem.View.DataViewerForm
    {
        public UsuarioViewerForm()
        {
            InitializeComponent();

            this.Janela_IDModulo = "1";
            this.Janela_Modulo = "Configurações do Sistema";
            this.Janela_IDModuloItem = "20";
            this.Janela_ModuloItem = "Cadastros";
            this.Janela_IDRotina = "200";
            this.Janela_Rotina = "Usuários";
            this.Janela_RotinaItem = new List<string>();

            this.Janela_RotinaItem.Add( "1 - Gravar" );
        }
    }
}
