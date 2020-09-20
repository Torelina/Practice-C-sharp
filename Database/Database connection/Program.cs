using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection
{
    class Program
    {
        static void Main(string[] args)
        {
            String ConSt = "Data Source=tsoop.c6oo9thiejqr.us-east-1.rds.amazonaws.com;Initial" +
                      " Catalog=TSOOPEX;User ID=admin;Password=Geirby1799";
            SqlConnection conection = new SqlConnection(ConSt);
            conection.Open();


            conection.Close();
        }
    }
}
