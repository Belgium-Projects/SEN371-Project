using SEN371_Project.Connection;
using SEN371_Project.Data;
using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project.FunctionalAreas
{
    internal class callCentre : dataLog
    {
       //CRUD operations 
       
        public override void deleteFromDB()
        {
            
            throw new NotImplementedException();
        }
        //save service ticket to db
        public override void saveToDB()
        {
            throw new NotImplementedException();
        }
        //View customer agreement
        public Services cusAgreement()
        {
            throw new NotImplementedException();
        }
        //Return customer call logs
        public List<string> callHistory()
        {
            //returns a calllog in this format 31/07/2023,10:37,11:00 so date,start,endofcall 
            List<string> calllogs = new List<string>();
            return calllogs;
        }
        // Returns client data from database
        public override List<client> selectFromDB()
        {
            throw new NotImplementedException();
        }
        //Update data from the db pretating to service ticket
        public override void updateFromDB()
        {
            throw new NotImplementedException();
        }
        //anwsers call
        public void anwsercall()
        {
            throw new NotImplementedException();
        }
        // end call
        public void endCall()
        {
            throw new NotImplementedException();
        }
    }
}
