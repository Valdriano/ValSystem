namespace ValSystem.View
{
    partial class DataViewerForm
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AdicionartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExcluirtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ImprimirtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LocalizartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AtualizartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MoveFirsttoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MoveLasttoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FechartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ViewerbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Quantidadetssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.Progressotsspb = new System.Windows.Forms.ToolStripProgressBar();
            this.Porcentagemtssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.Mensagemtssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewerbindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdicionartoolStripButton,
            this.EditartoolStripButton,
            this.ExcluirtoolStripButton,
            this.toolStripSeparator1,
            this.ImprimirtoolStripButton,
            this.LocalizartoolStripButton,
            this.AtualizartoolStripButton,
            this.toolStripSeparator2,
            this.MoveFirsttoolStripButton,
            this.MoveLasttoolStripButton,
            this.FechartoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(391, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Barra de Menu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // AdicionartoolStripButton
            // 
            this.AdicionartoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AdicionartoolStripButton.Image = global::ValSystem.View.Properties.Resources.add;
            this.AdicionartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AdicionartoolStripButton.Name = "AdicionartoolStripButton";
            this.AdicionartoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.AdicionartoolStripButton.Text = "Adicionar";
            this.AdicionartoolStripButton.Click += new System.EventHandler(this.AdicionartoolStripButton_Click);
            // 
            // EditartoolStripButton
            // 
            this.EditartoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditartoolStripButton.Image = global::ValSystem.View.Properties.Resources.application_edit;
            this.EditartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditartoolStripButton.Name = "EditartoolStripButton";
            this.EditartoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.EditartoolStripButton.Text = "Editar";
            this.EditartoolStripButton.Click += new System.EventHandler(this.EditartoolStripButton_Click);
            // 
            // ExcluirtoolStripButton
            // 
            this.ExcluirtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExcluirtoolStripButton.Image = global::ValSystem.View.Properties.Resources.delete;
            this.ExcluirtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcluirtoolStripButton.Name = "ExcluirtoolStripButton";
            this.ExcluirtoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.ExcluirtoolStripButton.Text = "Excluir";
            this.ExcluirtoolStripButton.Click += new System.EventHandler(this.ExcluirtoolStripButton_Click);
            // 
            // ImprimirtoolStripButton
            // 
            this.ImprimirtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ImprimirtoolStripButton.Image = global::ValSystem.View.Properties.Resources.printer;
            this.ImprimirtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImprimirtoolStripButton.Name = "ImprimirtoolStripButton";
            this.ImprimirtoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.ImprimirtoolStripButton.Text = "Imprimir";
            this.ImprimirtoolStripButton.Click += new System.EventHandler(this.ImprimirtoolStripButton_Click);
            // 
            // LocalizartoolStripButton
            // 
            this.LocalizartoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LocalizartoolStripButton.Image = global::ValSystem.View.Properties.Resources.find;
            this.LocalizartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LocalizartoolStripButton.Name = "LocalizartoolStripButton";
            this.LocalizartoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.LocalizartoolStripButton.Text = "Localizar";
            this.LocalizartoolStripButton.Click += new System.EventHandler(this.LocalizartoolStripButton_Click);
            // 
            // AtualizartoolStripButton
            // 
            this.AtualizartoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AtualizartoolStripButton.Image = global::ValSystem.View.Properties.Resources.arrow_refresh;
            this.AtualizartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AtualizartoolStripButton.Name = "AtualizartoolStripButton";
            this.AtualizartoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.AtualizartoolStripButton.Text = "Atualizar";
            this.AtualizartoolStripButton.Click += new System.EventHandler(this.AtualizartoolStripButton_Click);
            // 
            // MoveFirsttoolStripButton
            // 
            this.MoveFirsttoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveFirsttoolStripButton.Image = global::ValSystem.View.Properties.Resources.control_start_blue;
            this.MoveFirsttoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MoveFirsttoolStripButton.Name = "MoveFirsttoolStripButton";
            this.MoveFirsttoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.MoveFirsttoolStripButton.Text = "Move para Primeiro";
            this.MoveFirsttoolStripButton.Click += new System.EventHandler(this.MoveFirsttoolStripButton_Click);
            // 
            // MoveLasttoolStripButton
            // 
            this.MoveLasttoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveLasttoolStripButton.Image = global::ValSystem.View.Properties.Resources.control_end_blue;
            this.MoveLasttoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MoveLasttoolStripButton.Name = "MoveLasttoolStripButton";
            this.MoveLasttoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.MoveLasttoolStripButton.Text = "Move para Ultimo";
            this.MoveLasttoolStripButton.Click += new System.EventHandler(this.MoveLasttoolStripButton_Click);
            // 
            // FechartoolStripButton
            // 
            this.FechartoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FechartoolStripButton.Image = global::ValSystem.View.Properties.Resources.cancel;
            this.FechartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FechartoolStripButton.Name = "FechartoolStripButton";
            this.FechartoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.FechartoolStripButton.Text = "Fechar";
            this.FechartoolStripButton.Click += new System.EventHandler(this.FechartoolStripButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mensagemtssl,
            this.Quantidadetssl,
            this.Progressotsspb,
            this.Porcentagemtssl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 241);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(391, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Quantidadetssl
            // 
            this.Quantidadetssl.Name = "Quantidadetssl";
            this.Quantidadetssl.Size = new System.Drawing.Size(81, 17);
            this.Quantidadetssl.Text = "Quantidade: 0";
            this.Quantidadetssl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Progressotsspb
            // 
            this.Progressotsspb.Name = "Progressotsspb";
            this.Progressotsspb.Size = new System.Drawing.Size(100, 16);
            this.Progressotsspb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // Porcentagemtssl
            // 
            this.Porcentagemtssl.Name = "Porcentagemtssl";
            this.Porcentagemtssl.Size = new System.Drawing.Size(23, 17);
            this.Porcentagemtssl.Text = "0%";
            this.Porcentagemtssl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Mensagemtssl
            // 
            this.Mensagemtssl.Name = "Mensagemtssl";
            this.Mensagemtssl.Size = new System.Drawing.Size(170, 17);
            this.Mensagemtssl.Spring = true;
            this.Mensagemtssl.Text = "Mensagem";
            this.Mensagemtssl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 263);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "DataViewerForm";
            this.Text = "DataViewerForm";
            this.Shown += new System.EventHandler(this.DataViewerForm_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataViewerForm_KeyPress);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewerbindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.BindingSource ViewerbindingSource;
        private System.Windows.Forms.ToolStripButton AdicionartoolStripButton;
        private System.Windows.Forms.ToolStripButton EditartoolStripButton;
        private System.Windows.Forms.ToolStripButton ExcluirtoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ImprimirtoolStripButton;
        private System.Windows.Forms.ToolStripButton LocalizartoolStripButton;
        private System.Windows.Forms.ToolStripButton AtualizartoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton MoveFirsttoolStripButton;
        private System.Windows.Forms.ToolStripButton MoveLasttoolStripButton;
        private System.Windows.Forms.ToolStripButton FechartoolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Mensagemtssl;
        private System.Windows.Forms.ToolStripStatusLabel Quantidadetssl;
        private System.Windows.Forms.ToolStripProgressBar Progressotsspb;
        private System.Windows.Forms.ToolStripStatusLabel Porcentagemtssl;
    }
}