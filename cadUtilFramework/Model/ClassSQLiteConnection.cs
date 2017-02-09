using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class ClassSQLiteConnection : ClassConnection, IClassConnection
    {
        
        public override string getStringConnection()
        {
            return @"Data Source=.\cadastro.s3db"; ;
        }

        public override void AbrirConexao()
        {
            try
            {
                cn = new SQLiteConnection(getStringConnection());                
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
            }
            catch (SQLiteException ex)
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
            catch (SQLiteException ex)
            {
                throw ex;
            }
        }

        public override int ExecuteNonQuery(string sql)
        {
            cmd = new SQLiteCommand(sql, (SQLiteConnection)cn);            
            return cmd.ExecuteNonQuery();
        }

        public override DbDataReader ExecuteReader(string sql)
        {
            cmd = new SQLiteCommand(sql, (SQLiteConnection)cn);
            return cmd.ExecuteReader();
        }

        public override object ExecuteScalar(string sql)
        {
            cmd = new SQLiteCommand(sql, (SQLiteConnection)cn);
            return cmd.ExecuteScalar();
        }
    }
}
