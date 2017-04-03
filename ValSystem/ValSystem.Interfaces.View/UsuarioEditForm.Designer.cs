namespace ValSystem.Interfaces.View
{
    partial class UsuarioEditForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdUsuariotextBox = new System.Windows.Forms.TextBox();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.SenhatextBox = new System.Windows.Forms.TextBox();
            this.IdPerfiltextBox = new System.Windows.Forms.TextBox();
            this.BloqueadocheckBox = new System.Windows.Forms.CheckBox();
            this.PerfiltextBox = new System.Windows.Forms.TextBox();
            this.usuarioDataSet = new ValSystem.Interfaces.Model.UsuarioDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(399, 138);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Perfil:";
            // 
            // IdUsuariotextBox
            // 
            this.IdUsuariotextBox.Location = new System.Drawing.Point(86, 57);
            this.IdUsuariotextBox.Name = "IdUsuariotextBox";
            this.IdUsuariotextBox.ReadOnly = true;
            this.IdUsuariotextBox.Size = new System.Drawing.Size(52, 20);
            this.IdUsuariotextBox.TabIndex = 0;
            this.IdUsuariotextBox.TabStop = false;
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(86, 78);
            this.UsuariotextBox.MaxLength = 30;
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(269, 20);
            this.UsuariotextBox.TabIndex = 1;
            // 
            // SenhatextBox
            // 
            this.SenhatextBox.Location = new System.Drawing.Point(86, 99);
            this.SenhatextBox.MaxLength = 30;
            this.SenhatextBox.Name = "SenhatextBox";
            this.SenhatextBox.PasswordChar = '*';
            this.SenhatextBox.Size = new System.Drawing.Size(269, 20);
            this.SenhatextBox.TabIndex = 2;
            // 
            // IdPerfiltextBox
            // 
            this.IdPerfiltextBox.Location = new System.Drawing.Point(86, 120);
            this.IdPerfiltextBox.Name = "IdPerfiltextBox";
            this.IdPerfiltextBox.Size = new System.Drawing.Size(52, 20);
            this.IdPerfiltextBox.TabIndex = 3;
            this.IdPerfiltextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdPerfiltextBox_KeyPress);
            this.IdPerfiltextBox.Leave += new System.EventHandler(this.IdPerfiltextBox_Leave);
            // 
            // BloqueadocheckBox
            // 
            this.BloqueadocheckBox.AutoSize = true;
            this.BloqueadocheckBox.Location = new System.Drawing.Point(86, 144);
            this.BloqueadocheckBox.Name = "BloqueadocheckBox";
            this.BloqueadocheckBox.Size = new System.Drawing.Size(77, 17);
            this.BloqueadocheckBox.TabIndex = 6;
            this.BloqueadocheckBox.Text = "Bloqueado";
            this.BloqueadocheckBox.UseVisualStyleBackColor = true;
            // 
            // PerfiltextBox
            // 
            this.PerfiltextBox.Location = new System.Drawing.Point(139, 120);
            this.PerfiltextBox.Name = "PerfiltextBox";
            this.PerfiltextBox.ReadOnly = true;
            this.PerfiltextBox.Size = new System.Drawing.Size(216, 20);
            this.PerfiltextBox.TabIndex = 5;
            this.PerfiltextBox.TabStop = false;
            // 
            // usuarioDataSet
            // 
            this.usuarioDataSet.DataSetName = "UsuarioDataSet";
            this.usuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UsuarioEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(399, 177);
            this.Controls.Add(this.PerfiltextBox);
            this.Controls.Add(this.BloqueadocheckBox);
            this.Controls.Add(this.IdPerfiltextBox);
            this.Controls.Add(this.SenhatextBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.IdUsuariotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UsuarioEditForm";
            this.Text = "Usuário";
            this.Shown += new System.EventHandler(this.UsuarioEditForm_Shown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.IdUsuariotextBox, 0);
            this.Controls.SetChildIndex(this.UsuariotextBox, 0);
            this.Controls.SetChildIndex(this.SenhatextBox, 0);
            this.Controls.SetChildIndex(this.IdPerfiltextBox, 0);
            this.Controls.SetChildIndex(this.BloqueadocheckBox, 0);
            this.Controls.SetChildIndex(this.PerfiltextBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdUsuariotextBox;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.TextBox SenhatextBox;
        private System.Windows.Forms.TextBox IdPerfiltextBox;
        private System.Windows.Forms.CheckBox BloqueadocheckBox;
        private System.Windows.Forms.TextBox PerfiltextBox;
        private Model.UsuarioDataSet usuarioDataSet;
    }
}
