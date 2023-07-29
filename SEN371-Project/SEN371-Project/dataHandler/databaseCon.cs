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
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;
        SqlDataReader reader;

       public  void Connection()
        {
            try
            {
                connection.Open();
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
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
