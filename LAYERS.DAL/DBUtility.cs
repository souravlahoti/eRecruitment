using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Additional Declaration
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace LAYERS.DAL
{
    public class DBUtility
    {
        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            return conn;
        }
    }
}
