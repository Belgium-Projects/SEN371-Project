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
        //Connection and sql commands
        private static string connectionString = @"Data Source = Mthokozisi-2\SQLEXPRESS;Initial catalog =PremierServiceSolutions ;Integrated security = SSPI";
        private static SqlConnection connection = new SqlConnection(ConnectionString);
        private SqlCommand command;
        private SqlDataReader reader;

        //Encapsulation 
        public static string ConnectionString { get => connectionString; set => connectionString = value; }
        public SqlConnection Connection1 { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }

        //Methods
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
