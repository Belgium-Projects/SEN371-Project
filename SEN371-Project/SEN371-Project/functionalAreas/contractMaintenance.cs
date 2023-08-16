using SEN371_Project.Connection;
using SEN371_Project.Data;
using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
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
            try
            {
                Command = new System.Data.SqlClient.SqlCommand(getServies, Connection1);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    servicesInpackages.Add($"{Reader[0]},{Reader[1]},{Reader[2]},{Reader[3]},{Reader[4]},{Reader[5]},{Reader[6]},{Reader[7]}");
                }
                return servicesInpackages;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message +"ServicesinPackages");
            }
            finally
            {
                Disconnect();
            }
            return servicesInpackages;
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
