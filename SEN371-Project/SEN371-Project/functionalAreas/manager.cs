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
     
        public override void deleteFromDB()
        {
            throw new NotImplementedException();
        }

        public override void saveToDB()
        {
            throw new NotImplementedException();
        }

        public override List<client> selectFromDB()
        {
            throw new NotImplementedException();
        }

        public override void updateFromDB()
        {
            throw new NotImplementedException();
        }
        public void serviceRequest() { }
        public void closeService()
        {

        }
        public void contractPerformnace() { }
        public void employyeKPI() { }
        public void callHistory() { }
        public void reassignJobs() { }
        public void escalteJobs() { }

    }
}
