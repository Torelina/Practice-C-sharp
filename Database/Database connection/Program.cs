using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

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
            SqlCommand cmd = new SqlCommand("SELECT TOP (1000) [Name], [GroupName] FROM[TSOOPEX].[HumanResources].[Department]", conection);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()) 
            {

                Console.WriteLine(Convert.ToString(reader[0]));
            }
            conection.Close();

            
        }
    }
}
