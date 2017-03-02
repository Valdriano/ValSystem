using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValSystem.View
{
    public partial class AppForm : Form
    {
        public AppForm frmApp { get; set; }
        protected string Versao { get; set; }
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load( object sender, EventArgs e )
        {
            this.Mensagem_Status();
        }

        public void Mensagem_Status( string texto = "" )
        {
            if ( texto == string.Empty )
            {
                this.Statustssl.Text = "";
            }
            else
            {
                this.Statustssl.Text = texto;
            }

            this.Refresh();
        }

        private void AppForm_FormClosing( object sender, FormClosingEventArgs e )
        {
            Application.Exit();
        }
    }
}
