using SEN371_Project.Connection;
using SEN371_Project.Data;
using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project.FunctionalAreas
{
    internal class contractMaintenance : dataLog
    {
        //Manage availability of contract types

        public void avalabilityContract(string newAvalabilityStatus, int Servicesid)
        {
            string Change = $"update Packages set [Availability] = '{newAvalabilityStatus}' where PackagesID = {Servicesid}";
            Connection();
            try
            {
                Command = new System.Data.SqlClient.SqlCommand(Change, Connection1);
                Command.ExecuteNonQuery();
                MessageBox.Show($"Availability of {Servicesid} has been changed to {newAvalabilityStatus}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Disconnect();

        }
        public void update(string packageName,string Availability,string Discount,string PackagesID)
        {
            Connection();
            try
            {
                string update = $"update Packages set PackageName = '{packageName}',Availability = '{Availability}',Discount='{Discount}' where PackagesID ={PackagesID}";
                Command = new System.Data.SqlClient.SqlCommand (update, Connection1);
                Command.ExecuteNonQuery();
                MessageBox.Show($"{PackagesID} is updated");
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
        //Define service levels
        public List<string> defineServices()
        {
            Connection();
            List<string> allServiceslst = new List<string>();
            try
            {
                string allServices = $"Select * from Service ";
                Command = new System.Data.SqlClient.SqlCommand (allServices, Connection1);
                Reader = Command.ExecuteReader();
                while(Reader.Read())
                {
                    allServiceslst.Add($"{Reader[0]},{Reader[1]},{Reader[2]},{Reader[3]},{Reader[4]},{Reader[5]},{Reader[6]},{Reader[7]}");
                }
                return allServiceslst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
            finally
            {
                Disconnect();
            }
            return allServiceslst;
        }
      
        public List<string> definepackages()
        {
            string packages = "Select * from Packages p inner join SLA s on p.SLAID =s.SLAID";
            List<string> packagesList = new List<string>();
            Connection();
            try
            {
                Command = new System.Data.SqlClient.SqlCommand(packages, Connection1);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    packagesList.Add($"{Reader[0]},{Reader[1]},{Reader[2]},{Reader[3]},{Reader[4]},{Reader[5]},{Reader[6]},{Reader[7]},{Reader[8]}");
                }
                return packagesList;
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                Disconnect() ;
            }
            return packagesList; 
        }
        public List<string> serviesinPackages(string packagesID)
        {
            string getServies = $"select * from Service s inner join ServiceinPackages sp on s.ServicesID =sp.ServicesID inner join Packages p on sp.packagesID = p.PackagesID where p.packagesID = {packagesID}";
            Connection();
            List<string> servicesInpackages = new List<string>();
           
                Command = new System.Data.SqlClient.SqlCommand(getServies, Connection1);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    servicesInpackages.Add($"{Reader[0]},{Reader[1]},{Reader[2]},{Reader[3]},{Reader[4]},{Reader[5]},{Reader[6]},{Reader[7]}");
                }
            Disconnect();
            return servicesInpackages;
          
           
        }
        public void DeletePackages(string PackagesID)
        {
           
                Connection();
                try
                {
                    string delete = $"Delete from Packages where PackagesID = {PackagesID}";
                    Command = new System.Data.SqlClient.SqlCommand(delete, Connection1);
                    Command.ExecuteNonQuery();
                    MessageBox.Show("It has been deleted");
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
        public void insertservices(string MaintancesType, string DifficultMeasure, string Prices, string Frequency, string Task, string Description, string ToolsMaterials)
        {
            Connection();
            try
            {
                string insertservice = $"insert into Service(MaintancesType,DifficultMeasure,Prices,Frequency,Task,Description,ToolsMaterials)values('{MaintancesType}','{DifficultMeasure}',{Prices},'{Frequency}','{Task}','{Description}','{ToolsMaterials}')";
                Command = new System.Data.SqlClient.SqlCommand(insertservice, Connection1);
                Command.ExecuteNonQuery();
                MessageBox.Show("Service Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect ();
            }
        }
        public List<string> SLAID()
        {
            Connection();
            List<string> SLAID = new List<string>();
            try
            {
                string slaid = "Select SLAID from SLA";
                Command = new System.Data.SqlClient.SqlCommand(slaid, Connection1);
               Reader = Command.ExecuteReader();
                while (Reader.Read()) {
                    SLAID.Add($"{Reader[0].ToString()}");
                }
                return SLAID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            finally
            {
                Disconnect();
            }
            return SLAID;
            
        }
        public string Lastitem()
        {
            Connection();
            string PackagesID = "";
            try
            {
                string lastitem = $"select Top 1 packagesID from Packages order by PackagesID desc";
                Command = new System.Data.SqlClient.SqlCommand(lastitem,Connection1);
                Reader = Command.ExecuteReader();
                while ( Reader.Read())
                {
                    PackagesID = Reader[0].ToString();
                }
                return PackagesID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }
            return PackagesID;
        }
        public void insertservicesinpackages(string packagesID , CheckedListBox servicesID)
        {
            Connection();
            try
            {
                foreach (var item in servicesID.CheckedItems)
                {
                    List<string> itemBreakdown = item.ToString().Split(',').ToList();
                    string serviceinpackages = $"Insert into ServiceinPackages(packagesID,ServicesID) Values({packagesID},{itemBreakdown[0]});";
                    Command = new System.Data.SqlClient.SqlCommand (serviceinpackages, Connection1);
                    Command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Disconnect();
            }
        }
        public void InsertPackages(string PackagesName,string Availability , string Discount, string SLAID)
        {
            Connection();
            try
            {
                string insertpackages = $"Insert into Packages(PackageName,Availability,Discount,SLAID) Values('{PackagesName}','{Availability}',{Discount},{SLAID});";
                Command = new System.Data.SqlClient.SqlCommand(insertpackages, Connection1);
                Command.ExecuteNonQuery();
                MessageBox.Show("Packages Inserted");
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
        //View performance of contract types
        public void contractPerformnace() {
            throw new NotImplementedException();
        }
        public override void deleteFromDB()
        {
            throw new NotImplementedException();
        }
        //Define services offered
        public override void saveToDB()
        {
            throw new NotImplementedException();
        }
        
        //Manage availability of contract types
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
