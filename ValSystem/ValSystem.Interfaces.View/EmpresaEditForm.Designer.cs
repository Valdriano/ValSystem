namespace ValSystem.Interfaces.View
{
    partial class EmpresaEditForm
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
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataCadastrodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.RazaoSocialtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FantasiatextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EnderecotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumerotextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BairrotextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ComplementotextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CEPmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PaiscomboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.UFcomboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EstadocomboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CNPJmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TelefonemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.WebSitetextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.empresaDataSet = new ValSystem.Interfaces.Model.EmpresaDataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WebSitetextBox);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.EmailtextBox);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.TelefonemaskedTextBox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.CNPJmaskedTextBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.EstadocomboBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.UFcomboBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.PaiscomboBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.CEPmaskedTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ComplementotextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.BairrotextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.NumerotextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EnderecotextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.FantasiatextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.RazaoSocialtextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DataCadastrodateTimePicker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CodigotextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(471, 256);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Location = new System.Drawing.Point(107, 11);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.ReadOnly = true;
            this.CodigotextBox.Size = new System.Drawing.Size(60, 20);
            this.CodigotextBox.TabIndex = 0;
            this.CodigotextBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Cadastro:";
            // 
            // DataCadastrodateTimePicker
            // 
            this.DataCadastrodateTimePicker.Enabled = false;
            this.DataCadastrodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataCadastrodateTimePicker.Location = new System.Drawing.Point(350, 9);
            this.DataCadastrodateTimePicker.Name = "DataCadastrodateTimePicker";
            this.DataCadastrodateTimePicker.Size = new System.Drawing.Size(83, 20);
            this.DataCadastrodateTimePicker.TabIndex = 1;
            this.DataCadastrodateTimePicker.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Razão Social:";
            // 
            // RazaoSocialtextBox
            // 
            this.RazaoSocialtextBox.Location = new System.Drawing.Point(107, 33);
            this.RazaoSocialtextBox.MaxLength = 60;
            this.RazaoSocialtextBox.Name = "RazaoSocialtextBox";
            this.RazaoSocialtextBox.Size = new System.Drawing.Size(326, 20);
            this.RazaoSocialtextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fantasia:";
            // 
            // FantasiatextBox
            // 
            this.FantasiatextBox.Location = new System.Drawing.Point(107, 55);
            this.FantasiatextBox.MaxLength = 60;
            this.FantasiatextBox.Name = "FantasiatextBox";
            this.FantasiatextBox.Size = new System.Drawing.Size(326, 20);
            this.FantasiatextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Endereço:";
            // 
            // EnderecotextBox
            // 
            this.EnderecotextBox.Location = new System.Drawing.Point(107, 144);
            this.EnderecotextBox.MaxLength = 40;
            this.EnderecotextBox.Name = "EnderecotextBox";
            this.EnderecotextBox.Size = new System.Drawing.Size(207, 20);
            this.EnderecotextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Número:";
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.Location = new System.Drawing.Point(373, 144);
            this.NumerotextBox.MaxLength = 10;
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(60, 20);
            this.NumerotextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bairro:";
            // 
            // BairrotextBox
            // 
            this.BairrotextBox.Location = new System.Drawing.Point(107, 166);
            this.BairrotextBox.MaxLength = 40;
            this.BairrotextBox.Name = "BairrotextBox";
            this.BairrotextBox.Size = new System.Drawing.Size(145, 20);
            this.BairrotextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Complemento:";
            // 
            // ComplementotextBox
            // 
            this.ComplementotextBox.Location = new System.Drawing.Point(334, 166);
            this.ComplementotextBox.MaxLength = 30;
            this.ComplementotextBox.Name = "ComplementotextBox";
            this.ComplementotextBox.Size = new System.Drawing.Size(99, 20);
            this.ComplementotextBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cep:";
            // 
            // CEPmaskedTextBox
            // 
            this.CEPmaskedTextBox.Location = new System.Drawing.Point(107, 122);
            this.CEPmaskedTextBox.Mask = "99999-999";
            this.CEPmaskedTextBox.Name = "CEPmaskedTextBox";
            this.CEPmaskedTextBox.Size = new System.Drawing.Size(66, 20);
            this.CEPmaskedTextBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "País:";
            // 
            // PaiscomboBox
            // 
            this.PaiscomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PaiscomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PaiscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaiscomboBox.FormattingEnabled = true;
            this.PaiscomboBox.Location = new System.Drawing.Point(278, 76);
            this.PaiscomboBox.Name = "PaiscomboBox";
            this.PaiscomboBox.Size = new System.Drawing.Size(155, 21);
            this.PaiscomboBox.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "UF:";
            // 
            // UFcomboBox
            // 
            this.UFcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UFcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UFcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UFcomboBox.FormattingEnabled = true;
            this.UFcomboBox.Location = new System.Drawing.Point(107, 99);
            this.UFcomboBox.Name = "UFcomboBox";
            this.UFcomboBox.Size = new System.Drawing.Size(53, 21);
            this.UFcomboBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Estado:";
            // 
            // EstadocomboBox
            // 
            this.EstadocomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.EstadocomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EstadocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadocomboBox.FormattingEnabled = true;
            this.EstadocomboBox.Location = new System.Drawing.Point(263, 99);
            this.EstadocomboBox.Name = "EstadocomboBox";
            this.EstadocomboBox.Size = new System.Drawing.Size(170, 21);
            this.EstadocomboBox.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "CNPJ:";
            // 
            // CNPJmaskedTextBox
            // 
            this.CNPJmaskedTextBox.Location = new System.Drawing.Point(107, 77);
            this.CNPJmaskedTextBox.Mask = "999.999.999/9999-99";
            this.CNPJmaskedTextBox.Name = "CNPJmaskedTextBox";
            this.CNPJmaskedTextBox.Size = new System.Drawing.Size(127, 20);
            this.CNPJmaskedTextBox.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(179, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Telefones:";
            // 
            // TelefonemaskedTextBox
            // 
            this.TelefonemaskedTextBox.Location = new System.Drawing.Point(239, 123);
            this.TelefonemaskedTextBox.Mask = "( 99 ) 9999 - 9999 / ( 99 ) 9999 - 9999";
            this.TelefonemaskedTextBox.Name = "TelefonemaskedTextBox";
            this.TelefonemaskedTextBox.Size = new System.Drawing.Size(194, 20);
            this.TelefonemaskedTextBox.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(67, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Email:";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(107, 188);
            this.EmailtextBox.MaxLength = 60;
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(326, 20);
            this.EmailtextBox.TabIndex = 14;
            // 
            // WebSitetextBox
            // 
            this.WebSitetextBox.Location = new System.Drawing.Point(107, 210);
            this.WebSitetextBox.MaxLength = 60;
            this.WebSitetextBox.Name = "WebSitetextBox";
            this.WebSitetextBox.Size = new System.Drawing.Size(326, 20);
            this.WebSitetextBox.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "WebSite:";
            // 
            // empresaDataSet
            // 
            this.empresaDataSet.DataSetName = "EmpresaDataSet";
            this.empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpresaEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(471, 295);
            this.Name = "EmpresaEditForm";
            this.Text = "Empresa";
            this.Shown += new System.EventHandler(this.EmpresaEditForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DataCadastrodateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UFcomboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox PaiscomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox CEPmaskedTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ComplementotextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BairrotextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumerotextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EnderecotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FantasiatextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RazaoSocialtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox CNPJmaskedTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox EstadocomboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox TelefonemaskedTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox WebSitetextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label label15;
        private Model.EmpresaDataSet empresaDataSet;
    }
}
