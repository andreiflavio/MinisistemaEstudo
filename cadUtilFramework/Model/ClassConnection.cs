using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Reflection;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace Modelo
{
    public class ClassConnection : IDisposable, IClassConnection
    {
        public DbConnection cn = null;
        public DbCommand cmd = null;

        public virtual void AbrirConexao()
        {

        }

        public virtual void FecharConexao()
        {

        }

        public virtual int ExecuteNonQuery(string sql)
        {
            return 0;
        }

        public virtual DbDataReader ExecuteReader(string sql)
        {
            return null;
        }

        public virtual object ExecuteScalar(string sql)
        {
            return null;
        }

        public virtual string getStringConnection()
        {
            return string.Empty;
        }

        public void Dispose()
        {
            //Dispose(true);
            //GC.SuppressFinalize(this);
        }

        /*protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
            }
            // free native resources if there are any.
        }*/
    }
}
