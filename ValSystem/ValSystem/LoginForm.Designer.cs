namespace ValSystem
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.SenhatextBox = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Sairbutton = new System.Windows.Forms.Button();
            this.LoginstatusStrip = new System.Windows.Forms.StatusStrip();
            this.Versaotssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.LoginstatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UsuariotextBox.Location = new System.Drawing.Point(77, 14);
            this.UsuariotextBox.MaxLength = 30;
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(165, 20);
            this.UsuariotextBox.TabIndex = 0;
            // 
            // SenhatextBox
            // 
            this.SenhatextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SenhatextBox.Location = new System.Drawing.Point(77, 36);
            this.SenhatextBox.MaxLength = 30;
            this.SenhatextBox.Name = "SenhatextBox";
            this.SenhatextBox.PasswordChar = '*';
            this.SenhatextBox.Size = new System.Drawing.Size(165, 20);
            this.SenhatextBox.TabIndex = 1;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(77, 62);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 2;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Sairbutton
            // 
            this.Sairbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Sairbutton.Location = new System.Drawing.Point(167, 62);
            this.Sairbutton.Name = "Sairbutton";
            this.Sairbutton.Size = new System.Drawing.Size(75, 23);
            this.Sairbutton.TabIndex = 3;
            this.Sairbutton.Text = "Sair";
            this.Sairbutton.UseVisualStyleBackColor = true;
            this.Sairbutton.Click += new System.EventHandler(this.Sairbutton_Click);
            // 
            // LoginstatusStrip
            // 
            this.LoginstatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Versaotssl});
            this.LoginstatusStrip.Location = new System.Drawing.Point(0, 100);
            this.LoginstatusStrip.Name = "LoginstatusStrip";
            this.LoginstatusStrip.Size = new System.Drawing.Size(261, 24);
            this.LoginstatusStrip.SizingGrip = false;
            this.LoginstatusStrip.TabIndex = 6;
            this.LoginstatusStrip.Text = "Login";
            // 
            // Versaotssl
            // 
            this.Versaotssl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Versaotssl.Name = "Versaotssl";
            this.Versaotssl.Size = new System.Drawing.Size(246, 19);
            this.Versaotssl.Spring = true;
            this.Versaotssl.Text = "Versão: 1.0.0.0";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.OKbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Sairbutton;
            this.ClientSize = new System.Drawing.Size(261, 124);
            this.Controls.Add(this.LoginstatusStrip);
            this.Controls.Add(this.Sairbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.SenhatextBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginstatusStrip.ResumeLayout(false);
            this.LoginstatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.TextBox SenhatextBox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Sairbutton;
        private System.Windows.Forms.StatusStrip LoginstatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Versaotssl;
    }
}

