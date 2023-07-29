using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project.Connection
{
    internal class databaseCon
    {
        static string connectionString = @"";
        SqlConnection connection = new SqlConnection(ConnectionString);
        SqlCommand command;
        SqlDataReader reader;

        public static string ConnectionString { get => connectionString; set => connectionString = value; }
        public SqlConnection Connection1 { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }

        public  void Connection()
        {
            try
            {
                Connection1.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
       public void Disconnect()
        {
            try
            {
                Connection1.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
