namespace QuantosLivrosLiDesktop
{
    partial class LivroCRUD
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
            this.lblidLivro = new System.Windows.Forms.Label();
            this.cIdLivro = new System.Windows.Forms.TextBox();
            this.cNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.cDt_inicio = new System.Windows.Forms.DateTimePicker();
            this.lbldt_Inicio = new System.Windows.Forms.Label();
            this.lbldt_final = new System.Windows.Forms.Label();
            this.cDt_final = new System.Windows.Forms.DateTimePicker();
            this.lblObs = new System.Windows.Forms.Label();
            this.cObs = new System.Windows.Forms.TextBox();
            this.cIdSerie = new System.Windows.Forms.ComboBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.tbCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCRUD
            // 
            this.tbCRUD.Controls.Add(this.lblSerie);
            this.tbCRUD.Controls.Add(this.cIdSerie);
            this.tbCRUD.Controls.Add(this.cObs);
            this.tbCRUD.Controls.Add(this.lblObs);
            this.tbCRUD.Controls.Add(this.lbldt_final);
            this.tbCRUD.Controls.Add(this.cDt_final);
            this.tbCRUD.Controls.Add(this.lbldt_Inicio);
            this.tbCRUD.Controls.Add(this.cDt_inicio);
            this.tbCRUD.Controls.Add(this.lblNome);
            this.tbCRUD.Controls.Add(this.cNome);
            this.tbCRUD.Controls.Add(this.cIdLivro);
            this.tbCRUD.Controls.Add(this.lblidLivro);
            // 
            // lblidLivro
            // 
            this.lblidLivro.AutoSize = true;
            this.lblidLivro.Location = new System.Drawing.Point(58, 37);
            this.lblidLivro.Name = "lblidLivro";
            this.lblidLivro.Size = new System.Drawing.Size(21, 13);
            this.lblidLivro.TabIndex = 0;
            this.lblidLivro.Text = "ID:";
            // 
            // cIdLivro
            // 
            this.cIdLivro.Enabled = false;
            this.cIdLivro.Location = new System.Drawing.Point(85, 37);
            this.cIdLivro.Name = "cIdLivro";
            this.cIdLivro.ReadOnly = true;
            this.cIdLivro.Size = new System.Drawing.Size(100, 20);
            this.cIdLivro.TabIndex = 1;
            // 
            // cNome
            // 
            this.cNome.Location = new System.Drawing.Point(103, 63);
            this.cNome.MaxLength = 100;
            this.cNome.Name = "cNome";
            this.cNome.Size = new System.Drawing.Size(525, 20);
            this.cNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(58, 66);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // cDt_inicio
            // 
            this.cDt_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cDt_inicio.Location = new System.Drawing.Point(132, 92);
            this.cDt_inicio.Name = "cDt_inicio";
            this.cDt_inicio.Size = new System.Drawing.Size(200, 20);
            this.cDt_inicio.TabIndex = 4;
            // 
            // lbldt_Inicio
            // 
            this.lbldt_Inicio.AutoSize = true;
            this.lbldt_Inicio.Location = new System.Drawing.Point(58, 98);
            this.lbldt_Inicio.Name = "lbldt_Inicio";
            this.lbldt_Inicio.Size = new System.Drawing.Size(68, 13);
            this.lbldt_Inicio.TabIndex = 5;
            this.lbldt_Inicio.Text = "Comecei em:";
            // 
            // lbldt_final
            // 
            this.lbldt_final.AutoSize = true;
            this.lbldt_final.Location = new System.Drawing.Point(58, 124);
            this.lbldt_final.Name = "lbldt_final";
            this.lbldt_final.Size = new System.Drawing.Size(110, 13);
            this.lbldt_final.TabIndex = 7;
            this.lbldt_final.Text = "Terminei a leitura em: ";
            // 
            // cDt_final
            // 
            this.cDt_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cDt_final.Location = new System.Drawing.Point(174, 118);
            this.cDt_final.Name = "cDt_final";
            this.cDt_final.Size = new System.Drawing.Size(200, 20);
            this.cDt_final.TabIndex = 6;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(53, 299);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(73, 13);
            this.lblObs.TabIndex = 8;
            this.lblObs.Text = "Observações:";
            // 
            // cObs
            // 
            this.cObs.Location = new System.Drawing.Point(132, 296);
            this.cObs.Multiline = true;
            this.cObs.Name = "cObs";
            this.cObs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cObs.Size = new System.Drawing.Size(485, 101);
            this.cObs.TabIndex = 9;
            // 
            // cIdSerie
            // 
            this.cIdSerie.FormattingEnabled = true;
            this.cIdSerie.Location = new System.Drawing.Point(103, 153);
            this.cIdSerie.Name = "cIdSerie";
            this.cIdSerie.Size = new System.Drawing.Size(350, 21);
            this.cIdSerie.TabIndex = 10;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(58, 156);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(34, 13);
            this.lblSerie.TabIndex = 11;
            this.lblSerie.Text = "Série:";
            // 
            // LivroCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 527);
            this.Name = "LivroCRUD";
            this.Text = "LivroCRUD";
            this.tbCRUD.ResumeLayout(false);
            this.tbCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidLivro;
        private System.Windows.Forms.TextBox cIdLivro;
        private System.Windows.Forms.TextBox cNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DateTimePicker cDt_inicio;
        private System.Windows.Forms.Label lbldt_Inicio;
        private System.Windows.Forms.Label lbldt_final;
        private System.Windows.Forms.DateTimePicker cDt_final;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox cObs;
        private System.Windows.Forms.ComboBox cIdSerie;
        private System.Windows.Forms.Label lblSerie;
    }
}

