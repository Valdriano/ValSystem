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
            this.AdicionartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExcluirtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ImprimirtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LocalizartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AtualizartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MoveFirsttoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MoveLasttoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FechartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingSourceViewer = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceViewer)).BeginInit();
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 224);
            this.panel1.TabIndex = 1;
            // 
            // DataViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 263);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "DataViewerForm";
            this.Text = "DataViewerForm";
            this.Shown += new System.EventHandler(this.DataViewerForm_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataViewerForm_KeyPress);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.BindingSource bindingSourceViewer;
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
        public System.Windows.Forms.Panel panel1;
    }
}