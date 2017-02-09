using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Modelo
{
    interface IClassConnection
    {
        string getStringConnection();
        void AbrirConexao();
        void FecharConexao();
        int ExecuteNonQuery(string sql);
        DbDataReader ExecuteReader(string sql);
        object ExecuteScalar(string sql);
    }
}
