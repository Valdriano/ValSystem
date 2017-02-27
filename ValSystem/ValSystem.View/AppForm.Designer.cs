namespace ValSystem.View
{
    partial class AppForm
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
            this.statusStripApp = new System.Windows.Forms.StatusStrip();
            this.tsslVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripApp
            // 
            this.statusStripApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersao});
            this.statusStripApp.Location = new System.Drawing.Point(0, 388);
            this.statusStripApp.Name = "statusStripApp";
            this.statusStripApp.Size = new System.Drawing.Size(698, 24);
            this.statusStripApp.SizingGrip = false;
            this.statusStripApp.TabIndex = 1;
            this.statusStripApp.Text = "Status Menu";
            // 
            // tsslVersao
            // 
            this.tsslVersao.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslVersao.Name = "tsslVersao";
            this.tsslVersao.Size = new System.Drawing.Size(84, 19);
            this.tsslVersao.Text = "Versão: 1.0.0.0";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 412);
            this.Controls.Add(this.statusStripApp);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStripApp.ResumeLayout(false);
            this.statusStripApp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripApp;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersao;
    }
}