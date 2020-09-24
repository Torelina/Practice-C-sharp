using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DataBaseForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String ConSt = "Data Source=tsoop.c6oo9thiejqr.us-east-1.rds.amazonaws.com;Initial" +
                    " Catalog=TSOOPEX;User ID=admin;Password=Geirby1799";
           SqlConnection conection = new SqlConnection(ConSt);
            conection.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP (1000) [Name] FROM[TSOOPEX].[HumanResources].[Department]", conection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               // data.Add(new string[1]);
                //data[data.Count - 1][0] = reader[0].ToString();
                dataGridView1.Rows.Add(reader[0].ToString());
                //Console.WriteLine(Convert.ToString(reader[0]));
            }
            conection.Close();
        }
    }
}
