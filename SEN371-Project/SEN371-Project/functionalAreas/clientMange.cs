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
        //Need to add SQL here
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
                Disconnect();
                Connection();
                string Saverep = $"Select customerID from Customer where Name = '{companyName}'";
                Command = new System.Data.SqlClient.SqlCommand(Saverep, Connection1);
                Reader = Command.ExecuteReader();
                int customerID;
                while(Reader.Read() )
                {
                    customerID =int.Parse( Reader[0].ToString());
                }
                Disconnect();
                Connection();
                string AddCustoemr = "";
                Command = new System.Data.SqlClient.SqlCommand(AddCustoemr, Connection1);
                Command.ExecuteNonQuery();
                MessageBox.Show("Customer Saved");
                Disconnect();
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
        public List<string> manamgnentInfo()
        {
            string managesInfo = "select count(c.PackagesID), p.PackageName  from Customer c inner join Packages p on c.PackagesID = p.PackagesID group by p.PackageName";
            Connection();
            List<string> packagesCount = new List<string>();
            try
            {
                Command = new System.Data.SqlClient.SqlCommand(managesInfo, Connection1);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    packagesCount.Add($"{Reader[1]},{Reader[0]}");
                   
                }
                return packagesCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
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
