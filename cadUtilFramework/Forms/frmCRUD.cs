using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Controlador;

namespace Forms
{
    public partial class frmCRUD : frmBase
    {
        protected Boolean IsInsert;
        protected ToolStripButton[] Buttons = null;        

        class ItensComboBox
        {
            public string displayName { get; set; }
            public string fieldName { get; set; }
        }

        List<ItensComboBox> ListaItensComboBox = new List<ItensComboBox>();

        protected string itemSelecionadoCombobox
        {
            get {
                if (cbbFiltro.SelectedIndex > 0)
                    return ListaItensComboBox[cbbFiltro.SelectedIndex].fieldName;
                else return string.Empty;
            }
        }

        public frmCRUD()
        {
            if (DesignMode) return;
            InitializeComponent();
            gridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            btnPrintList.Visible = false;//TODO - Será feito recurso de impressão posteriormente
            IsInsert = false;
        }

        private void frmCRUD_Load(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;
            InitializeEventButtons();
            if (this.Text.Substring(this.Text.Length - 4, 4) == "CRUD")
                this.Text = this.Text.Substring(0, this.Text.Length - 4);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                DoFilter();
                SetQtRegistros();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorAddSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                DoSave();
                IsInsert = false;
                DoFilter();
                Listagem();
                MessageBox.Show("Operação concluída com sucesso.", "Cadastro OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            IsInsert = true;
            CRUD();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            SetBindingSource();
            CRUD();
        }

        private void Application_Idle(Object sender, EventArgs e)
        {
            DoActionUpdate();
        }

        private void SetQtRegistros()
        {
            int qt_registros = gridView.RowCount;
            tbListagem.Text = this.Text + ("(s)") + " [" + Convert.ToString(qt_registros) + "]";
        }

        protected void Listagem()
        {
            tb.SelectTab("tbListagem");
        }

        protected void CRUD()
        {
            tb.SelectedTab = tbCRUD;            
        }

        protected void MontaComboboxfiltros(DAL obj)
        {
            PropertyInfo[] props = obj.GetType().GetProperties();
            int instancePropsCount = props.Count();            
            InicializaCombobox();
            for (int i = 0; i < instancePropsCount; i++)
            {
                if (IsColumn(props[i]))
                {
                    System.ComponentModel.DisplayNameAttribute displayName = null;
                    try
                    {
                        displayName = ((System.ComponentModel.DisplayNameAttribute)(props[i].GetCustomAttributes(typeof(System.ComponentModel.DisplayNameAttribute), false)[0]));
                    }
                    catch
                    {
                        displayName = null;
                    }

                    if (displayName != null)
                    {
                        ItensComboBox item = new ItensComboBox();
                        item.displayName = displayName.DisplayName;
                        item.fieldName = props[i].Name;
                        ListaItensComboBox.Add(item);                        
                        cbbFiltro.Items.Add(item.displayName);
                    }
                }
            }
            cbbFiltro.SelectedIndex = 0;
        }

        private void InicializaCombobox()
        {
            ItensComboBox item = new ItensComboBox();
            item.displayName = String.Empty;
            item.fieldName = String.Empty;
            ListaItensComboBox.Add(item);
            cbbFiltro.Items.Add(String.Empty);
        }

        public bool IsColumn(PropertyInfo props)
        {
            object[] atributosMembro = props.GetCustomAttributes(typeof(System.Data.Linq.Mapping.ColumnAttribute), false);
            return atributosMembro.Count() > 0;
        }

        protected virtual void InitializeEventButtons()
        {
            if (Buttons != null)
            {
                for (int i = 0; i <= Buttons.Length - 1; i++)
                {
                    ProcessBar.Items.Add(Buttons[i]);
                    ProcessBar.Items.Add(new ToolStripSeparator());
                }
            }
        }

        protected override void DoClose()
        {
            if (MessageBox.Show("Deseja sair deste cadastro?", "Sair cadastro?", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else this.Close();
        }

        #region passíveis de sobrecarga
        protected virtual void DoActionUpdate()
        {
            bool enabled = (gridView.RowCount > 0) && (tb.SelectedTab == tbCRUD);
            bindingNavigatorDeleteItem.Enabled = enabled;
            bindingNavigatorAddSaveItem.Enabled = (tb.SelectedTab == tbCRUD);
        }

        protected virtual void SetBindingSource()
        {

        }

        protected virtual void DoSave()
        {
            throw new NotImplementedException();
        }

        protected virtual void DoFilter()
        {
            throw new NotImplementedException();
        }

        protected virtual void DoDelete()
        {
            throw new NotImplementedException();
        }
        #endregion

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir este registro?", "Apagar registro?", MessageBoxButtons.YesNo) == DialogResult.No)
                DoFilter();
            else
            {
                try
                {
                    DoDelete();
                    Listagem();
                    DoFilter();
                    MessageBox.Show("Operação concluída com sucesso.", "Exclusão OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {

        }

        private void btnCopySelectedItem_Click(object sender, EventArgs e)
        {
            if (this.gridView.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    // Add the selection to the clipboard.
                    Clipboard.SetDataObject(
                        this.gridView.GetClipboardContent());

                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    MessageBox.Show("Erro ao copiar informações para área de transferência.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.S):
                    {
                        bindingNavigatorAddSaveItem.PerformClick();
                        break;
                    }
                case (Keys.Control | Keys.Insert):
                    {
                        bindingNavigatorAddNewItem.PerformClick();
                        break;
                    }
                case (Keys.Control | Keys.Delete):
                    {
                        bindingNavigatorDeleteItem.PerformClick();
                        break;
                    }
                case (Keys.Control | Keys.C):
                    {
                        btnCopySelectedItem.PerformClick();
                        break;
                    }
                case (Keys.Control | Keys.Left):
                    {
                        bindingNavigatorMovePreviousItem.PerformClick();
                        break;
                    }
                case (Keys.Control | Keys.Right):
                    {
                        bindingNavigatorMoveNextItem.PerformClick();
                        break;
                    }
                case (Keys.Control | Keys.Home):
                    {
                        bindingNavigatorMoveFirstItem.PerformClick();
                        break;
                    }
                case (Keys.Control | Keys.End):
                    {
                        bindingNavigatorMoveLastItem.PerformClick();
                        break;
                    }

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void gridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.RowIndex % 2 == 0)
                {
                    e.CellStyle.BackColor = Color.Honeydew;
                }
                /*else
                {
                    e.CellStyle.BackColor = Color.White;
                    e.CellStyle.ForeColor = Color.Blue;
                }*/

            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            SetBindingSource();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            SetBindingSource();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            SetBindingSource();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            SetBindingSource();
        }
    }
}
