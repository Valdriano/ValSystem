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
            this.LoginstatusStrip = new System.Windows.Forms.StatusStrip();
            this.Versaotssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sairbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.SenhatextBox = new System.Windows.Forms.TextBox();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginstatusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginstatusStrip
            // 
            this.LoginstatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Versaotssl});
            this.LoginstatusStrip.Location = new System.Drawing.Point(0, 100);
            this.LoginstatusStrip.Name = "LoginstatusStrip";
            this.LoginstatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Sairbutton);
            this.panel1.Controls.Add(this.OKbutton);
            this.panel1.Controls.Add(this.SenhatextBox);
            this.panel1.Controls.Add(this.UsuariotextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 100);
            this.panel1.TabIndex = 7;
            // 
            // Sairbutton
            // 
            this.Sairbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Sairbutton.Location = new System.Drawing.Point(164, 63);
            this.Sairbutton.Name = "Sairbutton";
            this.Sairbutton.Size = new System.Drawing.Size(75, 23);
            this.Sairbutton.TabIndex = 9;
            this.Sairbutton.Text = "Sair";
            this.Sairbutton.UseVisualStyleBackColor = true;
            this.Sairbutton.Click += new System.EventHandler(this.Sairbutton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(74, 63);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 8;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // SenhatextBox
            // 
            this.SenhatextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SenhatextBox.Location = new System.Drawing.Point(74, 37);
            this.SenhatextBox.MaxLength = 30;
            this.SenhatextBox.Name = "SenhatextBox";
            this.SenhatextBox.PasswordChar = '*';
            this.SenhatextBox.Size = new System.Drawing.Size(165, 20);
            this.SenhatextBox.TabIndex = 6;
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UsuariotextBox.Location = new System.Drawing.Point(74, 15);
            this.UsuariotextBox.MaxLength = 30;
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(165, 20);
            this.UsuariotextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário:";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.OKbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.CancelButton = this.Sairbutton;
            this.ClientSize = new System.Drawing.Size(261, 124);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginstatusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginstatusStrip.ResumeLayout(false);
            this.LoginstatusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip LoginstatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Versaotssl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Sairbutton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.TextBox SenhatextBox;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

