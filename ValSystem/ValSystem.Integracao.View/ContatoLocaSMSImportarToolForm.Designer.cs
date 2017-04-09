namespace ValSystem.Integracao.View
{
    partial class ContatoLocaSMSImportarToolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DiretoriotextBox = new System.Windows.Forms.TextBox();
            this.Diretoriobutton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Diretoriobutton);
            this.panel1.Controls.Add(this.DiretoriotextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(489, 76);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivo:";
            // 
            // DiretoriotextBox
            // 
            this.DiretoriotextBox.Location = new System.Drawing.Point(87, 25);
            this.DiretoriotextBox.Name = "DiretoriotextBox";
            this.DiretoriotextBox.ReadOnly = true;
            this.DiretoriotextBox.Size = new System.Drawing.Size(307, 20);
            this.DiretoriotextBox.TabIndex = 1;
            this.DiretoriotextBox.TabStop = false;
            // 
            // Diretoriobutton
            // 
            this.Diretoriobutton.Image = global::ValSystem.Integracao.View.Properties.Resources.folder_explore;
            this.Diretoriobutton.Location = new System.Drawing.Point(395, 24);
            this.Diretoriobutton.Name = "Diretoriobutton";
            this.Diretoriobutton.Size = new System.Drawing.Size(40, 23);
            this.Diretoriobutton.TabIndex = 2;
            this.Diretoriobutton.UseVisualStyleBackColor = true;
            this.Diretoriobutton.Click += new System.EventHandler(this.Diretoriobutton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Arquivo";
            this.openFileDialog.Filter = "Arquivo Texto (*.txt)|*.txt|Arquivo CSV (*.csv)|*.csv";
            this.openFileDialog.Title = "Selecione o arquivo para importação";
            // 
            // ContatoLocaSMSImportarToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(489, 115);
            this.Name = "ContatoLocaSMSImportarToolForm";
            this.Text = "Importar Contatos LocaSMS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Diretoriobutton;
        private System.Windows.Forms.TextBox DiretoriotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
