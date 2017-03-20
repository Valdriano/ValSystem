using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValSystem.Controller;

namespace ValSystem.Interfaces.View
{
    public partial class MenuToolForm : ValSystem.View.ToolForm
    {
        public MenuToolForm()
        {
            InitializeComponent();

            this.Janela_IDModulo = "1";
            this.Janela_Modulo = "Configurações do Sistema";
            this.Janela_IDModuloItem = "10";
            this.Janela_ModuloItem = "Cadastros";
            this.Janela_IDRotina = "100";
            this.Janela_Rotina = "Menu do Sistema";
            this.Janela_RotinaItem = new List<string>();

            this.Janela_RotinaItem.Add( "1 - Executar" );
        }

        public override async void Executar( object sender, EventArgs e )
        {
            base.Executar( sender, e );

            try
            {
                DialogResult dialog = MessageBox.Show( this, $"Atenção deseja executar essa opção?", "Questionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question );

                if ( this.AtualizarMenuradioButton.Checked )
                {
                    Dictionary<string, int> dicionario = await new MenuController().CriarMenu();

                    if ( dicionario.Count > 0 )
                    {
                        MessageBox.Show( "Menu Atualizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information );

                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show( "Menu Atualizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    }
                }
            }
            catch ( ArgumentException ex )
            {
                MessageBox.Show( this, $"Erro\n\n{ex.Message}", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3 );
            }
            catch ( Exception ex )
            {

                MessageBox.Show( this, $"Erro\n\n{ex.Message}", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3 );
            }

        }
    }
}
