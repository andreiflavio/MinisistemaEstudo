namespace Forms
{
    partial class frmSQL
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.funçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executarQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.execSQLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarSCHEMAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.executarConsultaF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.execSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarSCHEMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.memoEdit1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(811, 404);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.TabIndex = 6;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.Location = new System.Drawing.Point(0, 24);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(811, 139);
            this.memoEdit1.TabIndex = 0;            
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funçõesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(811, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // funçõesToolStripMenuItem
            // 
            this.funçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executarQueryToolStripMenuItem,
            this.execSQLToolStripMenuItem1,
            this.visualizarSCHEMAToolStripMenuItem1});
            this.funçõesToolStripMenuItem.Name = "funçõesToolStripMenuItem";
            this.funçõesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.funçõesToolStripMenuItem.Text = "Funções";
            // 
            // executarQueryToolStripMenuItem
            // 
            this.executarQueryToolStripMenuItem.Name = "executarQueryToolStripMenuItem";
            this.executarQueryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.executarQueryToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.executarQueryToolStripMenuItem.Text = "Executar query";
            this.executarQueryToolStripMenuItem.Click += new System.EventHandler(this.executarQueryToolStripMenuItem_Click);
            // 
            // execSQLToolStripMenuItem1
            // 
            this.execSQLToolStripMenuItem1.Name = "execSQLToolStripMenuItem1";
            this.execSQLToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.execSQLToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.execSQLToolStripMenuItem1.Text = "ExecSQL";
            // 
            // visualizarSCHEMAToolStripMenuItem1
            // 
            this.visualizarSCHEMAToolStripMenuItem1.Name = "visualizarSCHEMAToolStripMenuItem1";
            this.visualizarSCHEMAToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.visualizarSCHEMAToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.visualizarSCHEMAToolStripMenuItem1.Text = "Visualizar SCHEMA";
            this.visualizarSCHEMAToolStripMenuItem1.Click += new System.EventHandler(this.visualizarSCHEMAToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // executarConsultaF5ToolStripMenuItem
            // 
            this.executarConsultaF5ToolStripMenuItem.Name = "executarConsultaF5ToolStripMenuItem";
            this.executarConsultaF5ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.executarConsultaF5ToolStripMenuItem.Text = "Executar consulta F5";
            // 
            // execSQLToolStripMenuItem
            // 
            this.execSQLToolStripMenuItem.Name = "execSQLToolStripMenuItem";
            this.execSQLToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.execSQLToolStripMenuItem.Text = "ExecSQL";
            // 
            // visualizarSCHEMAToolStripMenuItem
            // 
            this.visualizarSCHEMAToolStripMenuItem.Name = "visualizarSCHEMAToolStripMenuItem";
            this.visualizarSCHEMAToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.visualizarSCHEMAToolStripMenuItem.Text = "Visualizar SCHEMA";
            // 
            // frmSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 428);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "frmSQL";
            this.Text = "frmSQL";
            this.Load += new System.EventHandler(this.frmSQL_Load);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem executarConsultaF5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem execSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarSCHEMAToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem funçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executarQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem execSQLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visualizarSCHEMAToolStripMenuItem1;
    }
}