namespace ValSystem
{
    partial class MenuForm
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
            this.AppmenuStrip = new System.Windows.Forms.MenuStrip();
            this.Pesquisatstb = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.AppsplitContainer = new System.Windows.Forms.SplitContainer();
            this.MenutreeView = new System.Windows.Forms.TreeView();
            this.FavoritotreeView = new System.Windows.Forms.TreeView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppmenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppsplitContainer)).BeginInit();
            this.AppsplitContainer.Panel1.SuspendLayout();
            this.AppsplitContainer.Panel2.SuspendLayout();
            this.AppsplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppmenuStrip
            // 
            this.AppmenuStrip.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.AppmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pesquisatstb,
            this.toolStripMenuItem1,
            this.editarToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.AppmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AppmenuStrip.Name = "AppmenuStrip";
            this.AppmenuStrip.Size = new System.Drawing.Size(698, 27);
            this.AppmenuStrip.TabIndex = 3;
            this.AppmenuStrip.Text = "Menu";
            // 
            // Pesquisatstb
            // 
            this.Pesquisatstb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pesquisatstb.MaxLength = 200;
            this.Pesquisatstb.Name = "Pesquisatstb";
            this.Pesquisatstb.Size = new System.Drawing.Size(230, 23);
            this.Pesquisatstb.Enter += new System.EventHandler(this.Pesquisatstb_Enter);
            this.Pesquisatstb.Leave += new System.EventHandler(this.Pesquisatstb_Leave);
            this.Pesquisatstb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pesquisatstb_KeyPress);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reiniciarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 23);
            this.toolStripMenuItem1.Text = "Inicio";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 27);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(7, 361);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // AppsplitContainer
            // 
            this.AppsplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppsplitContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.AppsplitContainer.IsSplitterFixed = true;
            this.AppsplitContainer.Location = new System.Drawing.Point(7, 27);
            this.AppsplitContainer.Name = "AppsplitContainer";
            this.AppsplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // AppsplitContainer.Panel1
            // 
            this.AppsplitContainer.Panel1.Controls.Add(this.MenutreeView);
            this.AppsplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // AppsplitContainer.Panel2
            // 
            this.AppsplitContainer.Panel2.Controls.Add(this.FavoritotreeView);
            this.AppsplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AppsplitContainer.Size = new System.Drawing.Size(227, 361);
            this.AppsplitContainer.SplitterDistance = 213;
            this.AppsplitContainer.TabIndex = 5;
            // 
            // MenutreeView
            // 
            this.MenutreeView.BackColor = System.Drawing.SystemColors.Info;
            this.MenutreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenutreeView.Location = new System.Drawing.Point(0, 0);
            this.MenutreeView.Name = "MenutreeView";
            this.MenutreeView.ShowNodeToolTips = true;
            this.MenutreeView.Size = new System.Drawing.Size(225, 211);
            this.MenutreeView.TabIndex = 0;
            this.MenutreeView.DoubleClick += new System.EventHandler(this.MenutreeView_DoubleClick);
            // 
            // FavoritotreeView
            // 
            this.FavoritotreeView.BackColor = System.Drawing.SystemColors.Info;
            this.FavoritotreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FavoritotreeView.Location = new System.Drawing.Point(0, 0);
            this.FavoritotreeView.Name = "FavoritotreeView";
            this.FavoritotreeView.ShowNodeToolTips = true;
            this.FavoritotreeView.Size = new System.Drawing.Size(225, 142);
            this.FavoritotreeView.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(234, 27);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 361);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            this.splitter2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter2_SplitterMoved);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDoSistemaToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // menuDoSistemaToolStripMenuItem
            // 
            this.menuDoSistemaToolStripMenuItem.Name = "menuDoSistemaToolStripMenuItem";
            this.menuDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.menuDoSistemaToolStripMenuItem.Text = "Menu do Sistema";
            this.menuDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.menuDoSistemaToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.ajudaToolStripMenuItem.Text = "Ajuda?";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(698, 412);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.AppsplitContainer);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.AppmenuStrip);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.AppmenuStrip;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "ValSystem";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.Controls.SetChildIndex(this.AppmenuStrip, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.Controls.SetChildIndex(this.AppsplitContainer, 0);
            this.Controls.SetChildIndex(this.splitter2, 0);
            this.AppmenuStrip.ResumeLayout(false);
            this.AppmenuStrip.PerformLayout();
            this.AppsplitContainer.Panel1.ResumeLayout(false);
            this.AppsplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppsplitContainer)).EndInit();
            this.AppsplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AppmenuStrip;
        private System.Windows.Forms.ToolStripTextBox Pesquisatstb;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer AppsplitContainer;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TreeView MenutreeView;
        private System.Windows.Forms.TreeView FavoritotreeView;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
    }
}
