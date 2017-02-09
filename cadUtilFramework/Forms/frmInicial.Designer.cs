namespace Forms
{
    partial class frmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            this.btnMembros = new System.Windows.Forms.Button();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMembros
            // 
            this.btnMembros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembros.Image = ((System.Drawing.Image)(resources.GetObject("btnMembros.Image")));
            this.btnMembros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembros.Location = new System.Drawing.Point(12, 145);
            this.btnMembros.Name = "btnMembros";
            this.btnMembros.Size = new System.Drawing.Size(121, 86);
            this.btnMembros.TabIndex = 0;
            this.btnMembros.Text = "&Membros";
            this.btnMembros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMembros.UseVisualStyleBackColor = true;
            this.btnMembros.Click += new System.EventHandler(this.btnMembros_Click);
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentos.Location = new System.Drawing.Point(12, 27);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Size = new System.Drawing.Size(121, 86);
            this.btnDocumentos.TabIndex = 6;
            this.btnDocumentos.Text = "&Documentos";
            this.btnDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocumentos.UseVisualStyleBackColor = true;
            this.btnDocumentos.Click += new System.EventHandler(this.btnDocumentos_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanceiro.Location = new System.Drawing.Point(303, 27);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(121, 86);
            this.btnFinanceiro.TabIndex = 7;
            this.btnFinanceiro.Text = "&Financeiro";
            this.btnFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // btnConta
            // 
            this.btnConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConta.Location = new System.Drawing.Point(154, 27);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(121, 86);
            this.btnConta.TabIndex = 8;
            this.btnConta.Text = "&Conta";
            this.btnConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 401);
            this.Controls.Add(this.btnConta);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.btnDocumentos);
            this.Controls.Add(this.btnMembros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicial";
            this.Text = "Tela Inicial";
            this.Controls.SetChildIndex(this.btnMembros, 0);
            this.Controls.SetChildIndex(this.btnDocumentos, 0);
            this.Controls.SetChildIndex(this.btnFinanceiro, 0);
            this.Controls.SetChildIndex(this.btnConta, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMembros;
        private System.Windows.Forms.Button btnDocumentos;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnConta;
    }
}