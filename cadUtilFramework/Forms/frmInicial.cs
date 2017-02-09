using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class frmInicial : frmBase
    {
        public frmInicial()
        {
            InitializeComponent();            
            btnMembros.Visible = false;
            btnMembros.Enabled = false;
        }

        private void btnMembros_Click(object sender, EventArgs e)
        {
            CreateForm("PessoaForms", "MembroCRUD"); 
        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {
            CreateForm("DocumentosForms", "frmDoctos"); 
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            CreateForm("FinanceiroForms", "LancamentoCRUD"); 
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            CreateForm("FinanceiroForms", "ContaCRUD"); 
        }
    }
}
