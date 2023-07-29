using SEN371_Project.Connection;
using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project.Data
{
    abstract class dataLog : databaseCon
    {
        
        public abstract void saveToDB();
        public abstract void deleteFromDB();
        public abstract void updateFromDB();
        public abstract List<client> selectFromDB();
        
    }
}
