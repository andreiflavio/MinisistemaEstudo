using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class ClassSQLConnection : ClassConnection, IClassConnection
    {
        
        public override string getStringConnection()
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True;";
        }

        public override void AbrirConexao()
        {
            try
            {
                cn = new SqlConnection(getStringConnection());                
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
            }
            catch (SqlException ex)
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
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public override int ExecuteNonQuery(string sql)
        {
            cmd = new SqlCommand(sql, (SqlConnection)cn);            
            return cmd.ExecuteNonQuery();
        }

        public override DbDataReader ExecuteReader(string sql)
        {
            cmd = new SqlCommand(sql, (SqlConnection)cn);
            return cmd.ExecuteReader();
        }

        public override object ExecuteScalar(string sql)
        {
            cmd = new SqlCommand(sql, (SqlConnection)cn);
            return cmd.ExecuteScalar();
        }
    }
}
