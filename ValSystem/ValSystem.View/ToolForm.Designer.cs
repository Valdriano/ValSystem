namespace ValSystem.View
{
    partial class ToolForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExecutartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LocalizartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FechartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExecutartoolStripButton,
            this.LocalizartoolStripButton,
            this.FechartoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "Barra de Menu";
            // 
            // ExecutartoolStripButton
            // 
            this.ExecutartoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExecutartoolStripButton.Image = global::ValSystem.View.Properties.Resources.control_play_blue;
            this.ExecutartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExecutartoolStripButton.Name = "ExecutartoolStripButton";
            this.ExecutartoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.ExecutartoolStripButton.Text = "Executar";
            this.ExecutartoolStripButton.Click += new System.EventHandler(this.ExecutartoolStripButton_Click);
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
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ToolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ToolForm";
            this.Shown += new System.EventHandler(this.ToolForm_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToolForm_KeyPress);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExecutartoolStripButton;
        private System.Windows.Forms.ToolStripButton LocalizartoolStripButton;
        private System.Windows.Forms.ToolStripButton FechartoolStripButton;
    }
}