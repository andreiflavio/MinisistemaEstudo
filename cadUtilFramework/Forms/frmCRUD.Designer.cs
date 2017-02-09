namespace Forms
{
    partial class frmCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tb = new System.Windows.Forms.TabControl();
            this.tbListagem = new System.Windows.Forms.TabPage();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.ProcessBar = new System.Windows.Forms.ToolStrip();
            this.btnPrintList = new System.Windows.Forms.ToolStripButton();
            this.btnCopySelectedItem = new System.Windows.Forms.ToolStripButton();
            this.btnHideFiltroBar = new System.Windows.Forms.ToolStripButton();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.cbbFiltro = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.tbCRUD = new System.Windows.Forms.TabPage();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.tb.SuspendLayout();
            this.tbListagem.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.ProcessBar.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorAddSaveItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(832, 25);
            this.bindingNavigator.TabIndex = 1;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adiciona novo registro Ctrl + Insert";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move para o primeiro registro Ctrl + Home";
            this.bindingNavigatorMoveFirstItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move para o registro anterior Ctrl + Seta para esquerda";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move para o próximo registro Ctrl + seta para direita";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move para o último registro Ctrl + End";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddSaveItem
            // 
            this.bindingNavigatorAddSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddSaveItem.Image")));
            this.bindingNavigatorAddSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorAddSaveItem.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.bindingNavigatorAddSaveItem.Name = "bindingNavigatorAddSaveItem";
            this.bindingNavigatorAddSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddSaveItem.Text = "Salva as informações. Ctrl + S";
            this.bindingNavigatorAddSaveItem.Click += new System.EventHandler(this.bindingNavigatorAddSaveItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Apaga registro Ctrl + Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // tb
            // 
            this.tb.Controls.Add(this.tbListagem);
            this.tb.Controls.Add(this.tbCRUD);
            this.tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb.Location = new System.Drawing.Point(0, 49);
            this.tb.Name = "tb";
            this.tb.SelectedIndex = 0;
            this.tb.Size = new System.Drawing.Size(832, 478);
            this.tb.TabIndex = 2;
            // 
            // tbListagem
            // 
            this.tbListagem.Controls.Add(this.pnlGrid);
            this.tbListagem.Controls.Add(this.pnlFiltro);
            this.tbListagem.Location = new System.Drawing.Point(4, 22);
            this.tbListagem.Name = "tbListagem";
            this.tbListagem.Padding = new System.Windows.Forms.Padding(3);
            this.tbListagem.Size = new System.Drawing.Size(824, 452);
            this.tbListagem.TabIndex = 0;
            this.tbListagem.Text = "Listagem";
            this.tbListagem.UseVisualStyleBackColor = true;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridView);
            this.pnlGrid.Controls.Add(this.ProcessBar);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(3, 48);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(818, 401);
            this.pnlGrid.TabIndex = 1;
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.Size = new System.Drawing.Size(794, 401);
            this.gridView.TabIndex = 38;
            this.gridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridView_CellFormatting);
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // ProcessBar
            // 
            this.ProcessBar.AllowItemReorder = true;
            this.ProcessBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProcessBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProcessBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ProcessBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrintList,
            this.btnCopySelectedItem,
            this.btnHideFiltroBar});
            this.ProcessBar.Location = new System.Drawing.Point(794, 0);
            this.ProcessBar.Name = "ProcessBar";
            this.ProcessBar.Padding = new System.Windows.Forms.Padding(0, 50, 1, 0);
            this.ProcessBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ProcessBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProcessBar.Size = new System.Drawing.Size(24, 401);
            this.ProcessBar.TabIndex = 37;
            this.ProcessBar.Text = "Menu";
            // 
            // btnPrintList
            // 
            this.btnPrintList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrintList.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintList.Image")));
            this.btnPrintList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintList.Name = "btnPrintList";
            this.btnPrintList.Size = new System.Drawing.Size(21, 20);
            this.btnPrintList.Text = "&Imprimir";
            this.btnPrintList.Click += new System.EventHandler(this.btnPrintList_Click);
            // 
            // btnCopySelectedItem
            // 
            this.btnCopySelectedItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopySelectedItem.Image = ((System.Drawing.Image)(resources.GetObject("btnCopySelectedItem.Image")));
            this.btnCopySelectedItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopySelectedItem.Name = "btnCopySelectedItem";
            this.btnCopySelectedItem.Size = new System.Drawing.Size(21, 20);
            this.btnCopySelectedItem.Text = "Copia os itens selecionados para área de transferência permitindo colar o conteúd" +
    "o em qualquer outro aplicativo que desejar como excel ou bloco de notas. Ctrl + " +
    "C";
            this.btnCopySelectedItem.Click += new System.EventHandler(this.btnCopySelectedItem_Click);
            // 
            // btnHideFiltroBar
            // 
            this.btnHideFiltroBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHideFiltroBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHideFiltroBar.Name = "btnHideFiltroBar";
            this.btnHideFiltroBar.Size = new System.Drawing.Size(21, 4);
            this.btnHideFiltroBar.Text = "Esconder barra de filtragem";
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.cbbFiltro);
            this.pnlFiltro.Controls.Add(this.txtFiltro);
            this.pnlFiltro.Controls.Add(this.btnFiltrar);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(3, 3);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(818, 45);
            this.pnlFiltro.TabIndex = 0;
            // 
            // cbbFiltro
            // 
            this.cbbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFiltro.FormattingEnabled = true;
            this.cbbFiltro.Location = new System.Drawing.Point(5, 15);
            this.cbbFiltro.Name = "cbbFiltro";
            this.cbbFiltro.Size = new System.Drawing.Size(207, 21);
            this.cbbFiltro.TabIndex = 2;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Location = new System.Drawing.Point(218, 15);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(525, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFiltrar.Location = new System.Drawing.Point(743, 0);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 45);
            this.btnFiltrar.TabIndex = 0;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // tbCRUD
            // 
            this.tbCRUD.Location = new System.Drawing.Point(4, 22);
            this.tbCRUD.Name = "tbCRUD";
            this.tbCRUD.Padding = new System.Windows.Forms.Padding(3);
            this.tbCRUD.Size = new System.Drawing.Size(824, 452);
            this.tbCRUD.TabIndex = 1;
            this.tbCRUD.Text = "CRUD";
            this.tbCRUD.UseVisualStyleBackColor = true;
            // 
            // frmCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 527);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.bindingNavigator);
            this.Name = "frmCRUD";
            this.Text = "Cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCRUD_Load);
            this.Controls.SetChildIndex(this.bindingNavigator, 0);
            this.Controls.SetChildIndex(this.tb, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.tb.ResumeLayout(false);
            this.tbListagem.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ProcessBar.ResumeLayout(false);
            this.ProcessBar.PerformLayout();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabControl tb;
        private System.Windows.Forms.TabPage tbListagem;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Button btnFiltrar;
        protected System.Windows.Forms.BindingNavigator bindingNavigator;
        protected System.Windows.Forms.TabPage tbCRUD;
        protected System.Windows.Forms.ComboBox cbbFiltro;
        protected System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddSaveItem;
        protected System.Windows.Forms.ToolStrip ProcessBar;
        private System.Windows.Forms.ToolStripButton btnPrintList;
        private System.Windows.Forms.ToolStripButton btnHideFiltroBar;
        private System.Windows.Forms.ToolStripButton btnCopySelectedItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        protected System.Windows.Forms.DataGridView gridView;
        protected internal System.Windows.Forms.BindingSource bindingSource;
    }
}

