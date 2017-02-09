using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO.IsolatedStorage;
using System.IO;

namespace Forms
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        protected void CreateForm<T>(bool isMdiParent = true) where T : new()
        {
            T frm = Activator.CreateInstance<T>();

            if (isMdiParent)
                (frm as Form).Show(this);
            else
                (frm as Form).Show();
        }

        protected void CreateForm(string assemblyName, string className, bool isMdiParent = true)
        {
            FileInfo file = new FileInfo(assemblyName + ".dll");
            if (file != null)
            {
                string fullFilePath = String.Format(@"{0}", file.FullName);
                Assembly asb = Assembly.LoadFile(fullFilePath);
                object frm = asb.CreateInstance(assemblyName + "." + className);
                (frm as Form).Show();
            }
            else
            {
                throw new ApplicationException("Arquivo que possui o formulário não encontrado.");

            }
        }

        private void descobrirNomeFormulárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, this.Name, "Namespace tela");
        }

        private void consultasSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm<frmSQL>();
        }

        private void sairAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoClose();
        }

        protected virtual void DoClose()
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Sair?", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else this.Close();
        }

        protected void DefineVisibilidadeMenuBar(bool visible)
        {
            menuGeral.Visible = visible;
        }
    }
}
