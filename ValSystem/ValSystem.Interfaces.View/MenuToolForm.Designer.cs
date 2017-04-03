namespace ValSystem.Interfaces.View
{
    partial class MenuToolForm
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
            this.AtualizarMenuradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AtualizarMenuradioButton
            // 
            this.AtualizarMenuradioButton.AutoSize = true;
            this.AtualizarMenuradioButton.Location = new System.Drawing.Point(30, 51);
            this.AtualizarMenuradioButton.Name = "AtualizarMenuradioButton";
            this.AtualizarMenuradioButton.Size = new System.Drawing.Size(150, 17);
            this.AtualizarMenuradioButton.TabIndex = 3;
            this.AtualizarMenuradioButton.TabStop = true;
            this.AtualizarMenuradioButton.Text = "Atualizar Menu do Sistema";
            this.AtualizarMenuradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AtualizarMenuradioButton);
            this.groupBox1.Location = new System.Drawing.Point(35, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // MenuToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuToolForm";
            this.Text = "Menu do Sistema";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton AtualizarMenuradioButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
