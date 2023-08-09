using SEN371_Project.Connection;
using SEN371_Project.Data;
using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project.FunctionalAreas
{
    internal class clientMange : dataLog
    {
       
        public override void deleteFromDB()
        {
            throw new NotImplementedException();
        }
        // capture and maintain details of client both individual clients
        public override void saveToDB()
        {
            throw new NotImplementedException();
        }
        public void BusinessClient(string companyName,int packagesID,string phoneNumber ,string Email,string street , string city ,string zip)
        {
            string newClient = $"";
            Connection();
            try
            {
                Command = new System.Data.SqlClient.SqlCommand(newClient, Connection1);
                Command.ExecuteNonQuery();
                MessageBox.Show("Customer Entered");
                //Need way of adding Customer rep
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                Disconnect();
            }
        }
      //Capture details of service agreements with client
        public void serviceAgreement()
        {
            throw new NotImplementedException();
        }
        //Capture management information about client
        public void manamgnentInfo()
        {
            throw new NotImplementedException();
        }

        public override void updateFromDB()
        {
            throw new NotImplementedException();
        }

        public override List<client> selectFromDB(int client)
        {
            throw new NotImplementedException();
        }
    }
}
