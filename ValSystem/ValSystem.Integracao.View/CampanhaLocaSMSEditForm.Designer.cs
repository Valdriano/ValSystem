namespace ValSystem.Integracao.View
{
    partial class CampanhaLocaSMSEditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DadosgroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MensagemtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DatadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DescricaotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescricaoUsuarioLocaSMStextBox = new System.Windows.Forms.TextBox();
            this.IdUsuarioLocaSMStextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.bindingSourceConsultaItem = new System.Windows.Forms.BindingSource(this.components);
            this.campanhaLocaSMSDataSet = new ValSystem.Integracao.Model.CampanhaLocaSMSDataSet();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.Selecao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.DadosgroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceConsultaItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhaLocaSMSDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DadosgroupBox);
            this.panel1.Size = new System.Drawing.Size(864, 302);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // DadosgroupBox
            // 
            this.DadosgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DadosgroupBox.Controls.Add(this.label6);
            this.DadosgroupBox.Controls.Add(this.MensagemtextBox);
            this.DadosgroupBox.Controls.Add(this.label5);
            this.DadosgroupBox.Controls.Add(this.DatadateTimePicker);
            this.DadosgroupBox.Controls.Add(this.label4);
            this.DadosgroupBox.Controls.Add(this.DescricaotextBox);
            this.DadosgroupBox.Controls.Add(this.label3);
            this.DadosgroupBox.Controls.Add(this.DescricaoUsuarioLocaSMStextBox);
            this.DadosgroupBox.Controls.Add(this.IdUsuarioLocaSMStextBox);
            this.DadosgroupBox.Controls.Add(this.label2);
            this.DadosgroupBox.Controls.Add(this.IdtextBox);
            this.DadosgroupBox.Controls.Add(this.label1);
            this.DadosgroupBox.Location = new System.Drawing.Point(4, 3);
            this.DadosgroupBox.Name = "DadosgroupBox";
            this.DadosgroupBox.Size = new System.Drawing.Size(389, 250);
            this.DadosgroupBox.TabIndex = 1;
            this.DadosgroupBox.TabStop = false;
            this.DadosgroupBox.Text = "Dados";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(15, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Atenção: Em Mensagem, informe no máximo 155 caracteres. Não deverá utilizar na me" +
    "nsagem,";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MensagemtextBox
            // 
            this.MensagemtextBox.Location = new System.Drawing.Point(112, 91);
            this.MensagemtextBox.MaxLength = 155;
            this.MensagemtextBox.Multiline = true;
            this.MensagemtextBox.Name = "MensagemtextBox";
            this.MensagemtextBox.Size = new System.Drawing.Size(271, 70);
            this.MensagemtextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mensagem:";
            // 
            // DatadateTimePicker
            // 
            this.DatadateTimePicker.Enabled = false;
            this.DatadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatadateTimePicker.Location = new System.Drawing.Point(300, 27);
            this.DatadateTimePicker.Name = "DatadateTimePicker";
            this.DatadateTimePicker.Size = new System.Drawing.Size(83, 20);
            this.DatadateTimePicker.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data:";
            // 
            // DescricaotextBox
            // 
            this.DescricaotextBox.Location = new System.Drawing.Point(112, 70);
            this.DescricaotextBox.MaxLength = 40;
            this.DescricaotextBox.Name = "DescricaotextBox";
            this.DescricaotextBox.Size = new System.Drawing.Size(271, 20);
            this.DescricaotextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição:";
            // 
            // DescricaoUsuarioLocaSMStextBox
            // 
            this.DescricaoUsuarioLocaSMStextBox.Location = new System.Drawing.Point(171, 49);
            this.DescricaoUsuarioLocaSMStextBox.Name = "DescricaoUsuarioLocaSMStextBox";
            this.DescricaoUsuarioLocaSMStextBox.ReadOnly = true;
            this.DescricaoUsuarioLocaSMStextBox.Size = new System.Drawing.Size(212, 20);
            this.DescricaoUsuarioLocaSMStextBox.TabIndex = 3;
            this.DescricaoUsuarioLocaSMStextBox.TabStop = false;
            // 
            // IdUsuarioLocaSMStextBox
            // 
            this.IdUsuarioLocaSMStextBox.Location = new System.Drawing.Point(112, 49);
            this.IdUsuarioLocaSMStextBox.MaxLength = 4;
            this.IdUsuarioLocaSMStextBox.Name = "IdUsuarioLocaSMStextBox";
            this.IdUsuarioLocaSMStextBox.Size = new System.Drawing.Size(58, 20);
            this.IdUsuarioLocaSMStextBox.TabIndex = 2;
            this.IdUsuarioLocaSMStextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdUsuarioLocaSMStextBox_KeyPress);
            this.IdUsuarioLocaSMStextBox.Leave += new System.EventHandler(this.IdUsuarioLocaSMStextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário de Envio:";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(112, 27);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.ReadOnly = true;
            this.IdtextBox.Size = new System.Drawing.Size(58, 20);
            this.IdtextBox.TabIndex = 0;
            this.IdtextBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.advancedDataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(399, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 253);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contatos";
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            this.advancedDataGridView1.AllowUserToDeleteRows = false;
            this.advancedDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.advancedDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.advancedDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecao,
            this.Id,
            this.nomeDataGridViewTextBoxColumn,
            this.celular1DataGridViewTextBoxColumn,
            this.celular2DataGridViewTextBoxColumn,
            this.celular3DataGridViewTextBoxColumn,
            this.celular4DataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.bindingSourceConsultaItem;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView1.Location = new System.Drawing.Point(3, 16);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersVisible = false;
            this.advancedDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advancedDataGridView1.Size = new System.Drawing.Size(452, 234);
            this.advancedDataGridView1.TabIndex = 0;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // bindingSourceConsultaItem
            // 
            this.bindingSourceConsultaItem.DataMember = "ContatosLocaSMS";
            this.bindingSourceConsultaItem.DataSource = this.campanhaLocaSMSDataSet;
            this.bindingSourceConsultaItem.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSourceConsultaItem_ListChanged);
            // 
            // campanhaLocaSMSDataSet
            // 
            this.campanhaLocaSMSDataSet.DataSetName = "CampanhaLocaSMSDataSet";
            this.campanhaLocaSMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(860, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTotal
            // 
            this.tsslTotal.Name = "tsslTotal";
            this.tsslTotal.Size = new System.Drawing.Size(845, 17);
            this.tsslTotal.Spring = true;
            this.tsslTotal.Text = "Total: 0";
            // 
            // Selecao
            // 
            this.Selecao.HeaderText = "Sel";
            this.Selecao.MinimumWidth = 22;
            this.Selecao.Name = "Selecao";
            this.Selecao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Selecao.Width = 47;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 22;
            this.Id.Name = "Id";
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Id.Visible = false;
            this.Id.Width = 41;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nomeDataGridViewTextBoxColumn.Width = 60;
            // 
            // celular1DataGridViewTextBoxColumn
            // 
            this.celular1DataGridViewTextBoxColumn.DataPropertyName = "Celular1";
            this.celular1DataGridViewTextBoxColumn.HeaderText = "Celular 1";
            this.celular1DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.celular1DataGridViewTextBoxColumn.Name = "celular1DataGridViewTextBoxColumn";
            this.celular1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.celular1DataGridViewTextBoxColumn.Width = 73;
            // 
            // celular2DataGridViewTextBoxColumn
            // 
            this.celular2DataGridViewTextBoxColumn.DataPropertyName = "Celular2";
            this.celular2DataGridViewTextBoxColumn.HeaderText = "Celular 2";
            this.celular2DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.celular2DataGridViewTextBoxColumn.Name = "celular2DataGridViewTextBoxColumn";
            this.celular2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.celular2DataGridViewTextBoxColumn.Width = 73;
            // 
            // celular3DataGridViewTextBoxColumn
            // 
            this.celular3DataGridViewTextBoxColumn.DataPropertyName = "Celular3";
            this.celular3DataGridViewTextBoxColumn.HeaderText = "Celular 3";
            this.celular3DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.celular3DataGridViewTextBoxColumn.Name = "celular3DataGridViewTextBoxColumn";
            this.celular3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.celular3DataGridViewTextBoxColumn.Width = 73;
            // 
            // celular4DataGridViewTextBoxColumn
            // 
            this.celular4DataGridViewTextBoxColumn.DataPropertyName = "Celular4";
            this.celular4DataGridViewTextBoxColumn.HeaderText = "Celular 4";
            this.celular4DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.celular4DataGridViewTextBoxColumn.Name = "celular4DataGridViewTextBoxColumn";
            this.celular4DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.celular4DataGridViewTextBoxColumn.Width = 73;
            // 
            // CampanhaLocaSMSEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 341);
            this.Name = "CampanhaLocaSMSEditForm";
            this.Text = "Campanha LocaSMS";
            this.Shown += new System.EventHandler(this.CampanhaLocaSMSEditForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DadosgroupBox.ResumeLayout(false);
            this.DadosgroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceConsultaItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhaLocaSMSDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Model.CampanhaLocaSMSDataSet campanhaLocaSMSDataSet;
        private System.Windows.Forms.GroupBox DadosgroupBox;
        private System.Windows.Forms.DateTimePicker DatadateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescricaotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescricaoUsuarioLocaSMStextBox;
        private System.Windows.Forms.TextBox IdUsuarioLocaSMStextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MensagemtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.BindingSource bindingSourceConsultaItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular4DataGridViewTextBoxColumn;
    }
}
