namespace ValSystem.Integracao.View
{
    partial class UsuarioLocaSMSEditForm
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
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescricaotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.SenhatextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DataCadastrodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BloqueadocheckBox = new System.Windows.Forms.CheckBox();
            this.usuarioLocaSMSDataSet = new ValSystem.Integracao.Model.UsuarioLocaSMSDataSet();
            this.SaldonumericTextBox = new ValSystem.Controls.NumericTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioLocaSMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaldonumericTextBox);
            this.panel1.Controls.Add(this.BloqueadocheckBox);
            this.panel1.Controls.Add(this.DataCadastrodateTimePicker);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SenhatextBox);
            this.panel1.Controls.Add(this.LogintextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DescricaotextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IdtextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(347, 192);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(101, 24);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.ReadOnly = true;
            this.IdtextBox.Size = new System.Drawing.Size(62, 20);
            this.IdtextBox.TabIndex = 0;
            this.IdtextBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // DescricaotextBox
            // 
            this.DescricaotextBox.Location = new System.Drawing.Point(101, 47);
            this.DescricaotextBox.MaxLength = 40;
            this.DescricaotextBox.Name = "DescricaotextBox";
            this.DescricaotextBox.Size = new System.Drawing.Size(197, 20);
            this.DescricaotextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha:";
            // 
            // LogintextBox
            // 
            this.LogintextBox.Location = new System.Drawing.Point(101, 69);
            this.LogintextBox.MaxLength = 20;
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(197, 20);
            this.LogintextBox.TabIndex = 2;
            this.LogintextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LogintextBox_KeyPress);
            // 
            // SenhatextBox
            // 
            this.SenhatextBox.Location = new System.Drawing.Point(101, 91);
            this.SenhatextBox.MaxLength = 20;
            this.SenhatextBox.Name = "SenhatextBox";
            this.SenhatextBox.PasswordChar = '*';
            this.SenhatextBox.Size = new System.Drawing.Size(197, 20);
            this.SenhatextBox.TabIndex = 3;
            this.SenhatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SenhatextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Saldo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data Cadastro:";
            // 
            // DataCadastrodateTimePicker
            // 
            this.DataCadastrodateTimePicker.Enabled = false;
            this.DataCadastrodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataCadastrodateTimePicker.Location = new System.Drawing.Point(101, 136);
            this.DataCadastrodateTimePicker.Name = "DataCadastrodateTimePicker";
            this.DataCadastrodateTimePicker.Size = new System.Drawing.Size(84, 20);
            this.DataCadastrodateTimePicker.TabIndex = 5;
            this.DataCadastrodateTimePicker.TabStop = false;
            // 
            // BloqueadocheckBox
            // 
            this.BloqueadocheckBox.AutoSize = true;
            this.BloqueadocheckBox.Location = new System.Drawing.Point(101, 160);
            this.BloqueadocheckBox.Name = "BloqueadocheckBox";
            this.BloqueadocheckBox.Size = new System.Drawing.Size(77, 17);
            this.BloqueadocheckBox.TabIndex = 6;
            this.BloqueadocheckBox.Text = "Bloqueado";
            this.BloqueadocheckBox.UseVisualStyleBackColor = true;
            // 
            // usuarioLocaSMSDataSet
            // 
            this.usuarioLocaSMSDataSet.DataSetName = "UsuarioLocaSMSDataSet";
            this.usuarioLocaSMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaldonumericTextBox
            // 
            this.SaldonumericTextBox.Location = new System.Drawing.Point(101, 113);
            this.SaldonumericTextBox.Mask = "0.00";
            this.SaldonumericTextBox.Name = "SaldonumericTextBox";
            this.SaldonumericTextBox.ReadOnly = true;
            this.SaldonumericTextBox.Size = new System.Drawing.Size(62, 20);
            this.SaldonumericTextBox.TabIndex = 4;
            this.SaldonumericTextBox.TabStop = false;
            this.SaldonumericTextBox.Text = "0,00";
            this.SaldonumericTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SaldonumericTextBox.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // UsuarioLocaSMSEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(347, 231);
            this.Name = "UsuarioLocaSMSEditForm";
            this.Text = "Usuário LocaSMS";
            this.Shown += new System.EventHandler(this.UsuarioLocaSMSEditForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioLocaSMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Model.UsuarioLocaSMSDataSet usuarioLocaSMSDataSet;
        private System.Windows.Forms.CheckBox BloqueadocheckBox;
        private System.Windows.Forms.DateTimePicker DataCadastrodateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SenhatextBox;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescricaotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label label1;
        private Controls.NumericTextBox SaldonumericTextBox;
    }
}
