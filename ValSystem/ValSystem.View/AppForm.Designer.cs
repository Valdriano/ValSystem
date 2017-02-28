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
            this.AppstatusStrip = new System.Windows.Forms.StatusStrip();
            this.Versaotssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.AppstatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppstatusStrip
            // 
            this.AppstatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Versaotssl});
            this.AppstatusStrip.Location = new System.Drawing.Point(0, 388);
            this.AppstatusStrip.Name = "AppstatusStrip";
            this.AppstatusStrip.Size = new System.Drawing.Size(698, 24);
            this.AppstatusStrip.SizingGrip = false;
            this.AppstatusStrip.TabIndex = 1;
            this.AppstatusStrip.Text = "Status Menu";
            // 
            // Versaotssl
            // 
            this.Versaotssl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Versaotssl.Name = "Versaotssl";
            this.Versaotssl.Size = new System.Drawing.Size(84, 19);
            this.Versaotssl.Text = "Versão: 1.0.0.0";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 412);
            this.Controls.Add(this.AppstatusStrip);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.AppstatusStrip.ResumeLayout(false);
            this.AppstatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip AppstatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Versaotssl;
    }
}