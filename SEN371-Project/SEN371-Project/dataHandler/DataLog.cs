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
        //classes for basic CRUD
        // Save data to DB
        public abstract void saveToDB();
        //Delete item form db
        public abstract void deleteFromDB();
        //Update form the db
        public abstract void updateFromDB();
        //return a list of client 
        public abstract List<client> selectFromDB();
        
    }
}
