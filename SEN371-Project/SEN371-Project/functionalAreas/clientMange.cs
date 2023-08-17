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
        // capture and maintain details of individual clients
        public override void saveToDB()
        {
            throw new NotImplementedException();
        }
        //Adds BusinessCLient and all the reps 
        public void BusinessClient(string companyName,int packagesID ,string street , string city ,string zip,List<string> bussinessRep)
        {
            //Add customer to customer Table
            string newClient = $"insert into Customer(Name,Surname,Street,City,zip,PackagesID,PhoneNumber,Email,DOB)Values('Business','{companyName}','{street}','{city}','{zip}',{packagesID},'','','');";
            Connection();
            try
            {
                int customerID =0;
                //add business Customer to the db
                Command = new System.Data.SqlClient.SqlCommand(newClient, Connection1);
                Command.ExecuteNonQuery();
               
                //Need way of adding Customer rep
                Disconnect();
                //Gets customer ID
                Connection();
                string Saverep = $"Select customerID from Customer where Surname = '{companyName}'";
                Command = new System.Data.SqlClient.SqlCommand(Saverep, Connection1);
                Reader = Command.ExecuteReader();
                
                while(Reader.Read() )
                {
                    customerID =int.Parse( Reader[0].ToString());
                }
                Disconnect();

                //Will add Bussiness rep
                List<int> businessRoleID = new List<int>();
                foreach (var item in bussinessRep)
                {
                    //BusinessRole,Name,Surname,ContactNumber
                    List<string> Breakdown = item.Split(',').ToList();
                    Connection();

                    string addcustomerRep = $"insert into BusinessRole(BusinessRole,Name,Surname,ContactNumber) Values('{Breakdown[0]}','{Breakdown[1]}','{Breakdown[2]},','{Breakdown[3]}');";
                    Command = new System.Data.SqlClient.SqlCommand(addcustomerRep, Connection1);
                    Command.ExecuteNonQuery();
                    
                    Disconnect();
                    Connection();
                    string businessRole = $"Select BusinessRoleID from BusinessRole where BusinessRole = '{Breakdown[0]}' and Name = '{Breakdown[1]}' and Surname ='{Breakdown[2]},' and ContactNumber = '{Breakdown[3]}'";
                    Command = new System.Data.SqlClient.SqlCommand(businessRole, Connection1);
                    Reader = Command.ExecuteReader() ;
                    while( Reader.Read() ) {
                        businessRoleID.Add(int.Parse(Reader[0].ToString()));
                    }
                    Disconnect();
                }
                //Linking Business Role to Customer 
                foreach (var item in businessRoleID)
                {
                    Connection();
                    string BusinessCustomer = $"insert into BusinessCustomer(CustomerID,BusinessRoleID)Values({customerID},{item})";
                   Command = new System.Data.SqlClient.SqlCommand(BusinessCustomer, Connection1);
                    Command.ExecuteNonQuery();
                   
                    Disconnect();
                }
               
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
        public void serviceAgreement(int customerID,int packagesID,string PackagesName,string availability,string expireDate,string startDate)
        {
            Connection();
            string insertPackages;
            string insertSLA;
            try
            {

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
