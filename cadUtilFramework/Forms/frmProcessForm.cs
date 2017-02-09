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
    public partial class frmProcessForm : frmBase
    {
        public frmProcessForm()
        {
            if (DesignMode) return;
            InitializeComponent();
            DefineVisibilidadeMenuBar(false);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                DoExecute();
                MessageBox.Show("Operação concluída com sucesso.", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void DoExecute()
        {
            throw new NotImplementedException();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DoCancel();
        }

        protected virtual void DoCancel()
        {
            
        }
    }
}
