using SEN371_Project.Connection;
using SEN371_Project.Data;
using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class serviceDept : DataLog
    {
        public void serviceRequest() { }
        public override void deleteFromDB()
        {
            throw new NotImplementedException();
        }

        public override void saveToDB()
        {
            throw new NotImplementedException();
        }
        public void closeService()
        {

        }
        public override List<client> selectFromDB()
        {
            throw new NotImplementedException();
        }

        public override void updateFromDB()
        {
            throw new NotImplementedException();
        }
    }
}
