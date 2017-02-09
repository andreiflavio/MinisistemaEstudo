using MySql.Data.MySqlClient;
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
    public class ClassMySQLConnection : ClassConnection, IClassConnection
    {
        
        public override string getStringConnection()
        {
            return @"Server=localhost;Database=cadastro;Uid=root;Pwd=admin1234;";
        }

        public override void AbrirConexao()
        {
            try
            {
                cn = new MySqlConnection(getStringConnection());                
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
            }
            catch (MySqlException ex)
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
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public override int ExecuteNonQuery(string sql)
        {
            cmd = new MySqlCommand(sql, (MySqlConnection)cn);            
            return cmd.ExecuteNonQuery();
        }

        public override DbDataReader ExecuteReader(string sql)
        {
            cmd = new MySqlCommand(sql, (MySqlConnection)cn);
            return cmd.ExecuteReader();
        }

        public override object ExecuteScalar(string sql)
        {
            cmd = new MySqlCommand(sql, (MySqlConnection)cn);
            return cmd.ExecuteScalar();
        }
    }
}
