﻿using SEN371_Project.Connection;
using SEN371_Project.Data;
using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class serviceDept : dataLog
    {
      //Receive service request
        public void serviceRequest() { 
            throw new NotImplementedException(); 
        }
        //public List<Jobs> returnJobs()
        //{
        //    List<Jobs> returnJobs = new List<Jobs>();
        //    try
        //    {
        //        Connection();
        //        string jobs = $"Select * from Jobs";
        //        Command = new System.Data.SqlClient.SqlCommand(jobs,Connection1);
        //        Reader = Command.ExecuteReader();

        //        while (Reader.Read())
        //        {
        //            //returnJobs.Add(new Jobs(Reader[0]))
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        Disconnect();
        //    }
        //}
        //Assign request 
        public void assignRequest()
        {
            throw new NotImplementedException();
        }
        //Trackjob returns a status on job
        public string TrackJobs()
        {
            throw new NotImplementedException();
    }
        public override void deleteFromDB()
        {
            throw new NotImplementedException();
        }
        //override to add ticket
        public override void saveToDB()
        {
            throw new NotImplementedException();
        }
        //Closes services request
        public void closeService()
        {
            throw new NotImplementedException();
        }
        //Returns client who request ticket 
        public override List<client> selectFromDB(int clientID)
        {
            throw new NotImplementedException();
        }
        //add notes and update ticket
        public override void updateFromDB()
        {
            throw new NotImplementedException();
        }
        //Re- assign jobs
        public void reAssign()
        {
            throw new NotImplementedException();
        }
        //Escalte jobs
        public void escaltejob()
        {
            throw new NotImplementedException();
        }
    }
}
