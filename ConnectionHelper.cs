using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

//klasa musi przyjmować commandtext, żeby wiedzieć jaką storedprocedure wywołać
//musi przyjmować parametry procedury w jednej z metod

namespace MojeFinanse
{
    public class ConnectionHelper {
        public string connectionString { get; set; }
        //string connectionString = string.Empty;
        
        public ConnectionHelper()
        {
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["MojeRachunki_DataEntities"].ConnectionString;
            }
            catch (Exception)
            {
                //todo error handling  mechanism
                throw;
            }
        }

        //insert data connection
        public void OpenConnection(string cmdText, params SqlParameter[] parameters)
        {
            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(cmdText, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
        }     
    }
}
