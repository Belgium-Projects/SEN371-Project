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
        public void defineServices()
        {
            throw new NotImplementedException();
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
