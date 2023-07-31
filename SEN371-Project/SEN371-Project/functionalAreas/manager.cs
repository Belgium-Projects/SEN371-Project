using SEN371_Project.Connection;
using SEN371_Project.Data;
using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project.FunctionalAreas
{
    internal class manager : dataLog
    {
        //Remove service ticket
        public override void deleteFromDB()
        {
            throw new NotImplementedException();
        }
        //add service ticket
        public override void saveToDB()
        {
            throw new NotImplementedException();
        }
        //Return tickets from client 
        public override List<client> selectFromDB()
        {
            throw new NotImplementedException();
        }
        //Update info on services tickets
        public override void updateFromDB()
        {
            throw new NotImplementedException();
        }
        //change services request info
        public void serviceRequest() {
            throw new NotImplementedException();
        }
        //closes a service tickets
        public void closeService()
        {
            throw new NotImplementedException();
        }
        //view preformance of packages
        public List<Services> contractPerformnace() {
            throw new NotImplementedException();
        }
        //Return employee data from api so will pop up graphs
        public void employyeKPI() {
            throw new NotImplementedException();
        }
        public List<string> callHistory() {
            //returns a calllog in this format 31/07/2023,10:37,11:00 so date,start,endofcall 
            List<string> calllogs = new List<string>();
           
            throw new NotImplementedException();
        }
        //Reasign a service ticket to other person
        public void reassignJobs() {
            throw new NotImplementedException();
        }
        //change priority of a ticket 
        public void escalteJobs() {
            throw new NotImplementedException();
        }

    }
}
