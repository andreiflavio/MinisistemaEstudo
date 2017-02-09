using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class ClassAcessConnection : ClassConnection, IClassConnection
    {
        
        public override string getStringConnection()
        {
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\sistemaFinanceiroPessoal.mdb";
        }

        public override void AbrirConexao()
        {
            try
            {
                cn = new OleDbConnection(getStringConnection());
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }

        public override void FecharConexao()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }

        public override int ExecuteNonQuery(string sql)
        {
            cmd = new OleDbCommand(sql, (OleDbConnection)cn);            
            return cmd.ExecuteNonQuery();
        }

        public override DbDataReader ExecuteReader(string sql)
        {
            cmd = new OleDbCommand(sql, (OleDbConnection)cn);
            return cmd.ExecuteReader();
        }

        public override object ExecuteScalar(string sql)
        {
            cmd = new OleDbCommand(sql, (OleDbConnection)cn);
            return cmd.ExecuteScalar();
        }
    }
}
