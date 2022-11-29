using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLTV_OOP.DAL
{
    class DataConnection
    {
        string connectStr;
        public DataConnection()
        {
            connectStr = "Data Source =. ; Initial Catalog=QLTV2; Integrated Security=True";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(connectStr);
        }
    }
}
