using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using Controlador;

namespace Forms
{
    public partial class frmSQL : frmBase
    {
        public frmSQL()
        {
            InitializeComponent();
        }

        private void AtualizaGrid(string sql, bool schema = false)
        {
            //TODO - FAzer isso no novo formato
            /*using (OleDbConnection conn = ClassConnectionController.getConnection())
            {
                conn.Open();
                try
                {
                    if (!schema)
                    {
                        OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        OleDbCommand cmd = new OleDbCommand(memoEdit1.Text, conn);
                        OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.KeyInfo);
                        DataTable dt = reader.GetSchemaTable();
                        dataGridView1.DataSource = dt;
                    }
                }
                finally
                {
                    conn.Close();
                }

            }*/
        }

        private void frmSQL_Load(object sender, EventArgs e)
        {
            
        }

        private void visualizarSCHEMAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MySQL basta ser o comando describe + [NOME_TABELA]
            AtualizaGrid(memoEdit1.SelectedText, true);
        }

        private void executarQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizaGrid(memoEdit1.SelectedText);
        }
    }
}
