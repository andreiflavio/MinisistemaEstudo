namespace Forms
{
    partial class frmBase
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
            this.menuGeral = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeAniversariantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descobrirNomeFormulárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGeral
            // 
            this.menuGeral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.relatórioDeAniversariantesToolStripMenuItem,
            this.utilitáriosToolStripMenuItem});
            this.menuGeral.Location = new System.Drawing.Point(0, 0);
            this.menuGeral.Name = "menuGeral";
            this.menuGeral.Size = new System.Drawing.Size(284, 24);
            this.menuGeral.TabIndex = 5;
            this.menuGeral.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairAltF4ToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairAltF4ToolStripMenuItem
            // 
            this.sairAltF4ToolStripMenuItem.Name = "sairAltF4ToolStripMenuItem";
            this.sairAltF4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairAltF4ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sairAltF4ToolStripMenuItem.Text = "Sair";
            this.sairAltF4ToolStripMenuItem.Click += new System.EventHandler(this.sairAltF4ToolStripMenuItem_Click);
            // 
            // relatórioDeAniversariantesToolStripMenuItem
            // 
            this.relatórioDeAniversariantesToolStripMenuItem.Name = "relatórioDeAniversariantesToolStripMenuItem";
            this.relatórioDeAniversariantesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatórioDeAniversariantesToolStripMenuItem.Text = "Relatórios";
            // 
            // utilitáriosToolStripMenuItem
            // 
            this.utilitáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descobrirNomeFormulárioToolStripMenuItem,
            this.consultasSQLToolStripMenuItem});
            this.utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            this.utilitáriosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utilitáriosToolStripMenuItem.Text = "Utilitários";
            // 
            // descobrirNomeFormulárioToolStripMenuItem
            // 
            this.descobrirNomeFormulárioToolStripMenuItem.Name = "descobrirNomeFormulárioToolStripMenuItem";
            this.descobrirNomeFormulárioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.descobrirNomeFormulárioToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.descobrirNomeFormulárioToolStripMenuItem.Text = "Descobrir nome formulário";
            this.descobrirNomeFormulárioToolStripMenuItem.Click += new System.EventHandler(this.descobrirNomeFormulárioToolStripMenuItem_Click);
            // 
            // consultasSQLToolStripMenuItem
            // 
            this.consultasSQLToolStripMenuItem.Name = "consultasSQLToolStripMenuItem";
            this.consultasSQLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.consultasSQLToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.consultasSQLToolStripMenuItem.Text = "Consultas SQL";
            this.consultasSQLToolStripMenuItem.Click += new System.EventHandler(this.consultasSQLToolStripMenuItem_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuGeral);
            this.Name = "frmBase";
            this.Text = "frmBase";
            this.menuGeral.ResumeLayout(false);
            this.menuGeral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeAniversariantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descobrirNomeFormulárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasSQLToolStripMenuItem;
        protected internal System.Windows.Forms.MenuStrip menuGeral;
    }
}