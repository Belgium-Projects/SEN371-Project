using SEN371_Project.Connection;
using SEN371_Project.Data;
using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project
{
    internal class serviceDept : dataLog
    {
      //Receive service request
        public void serviceRequest() { 
            throw new NotImplementedException(); 
        }
        public List<string> returnJobs()
        {
            List<string> returnJobs = new List<string>();
            try
            {
                Connection();
                string jobs = $"Select * from Jobs";
                Command = new System.Data.SqlClient.SqlCommand(jobs, Connection1);
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    returnJobs.Add($"{Reader[0].ToString()}, {Reader[1].ToString()}, {Reader[2].ToString()}, {Reader[3].ToString()}, {Reader[4].ToString()}, {Reader[5].ToString()}, {Reader[6].ToString()}, {Reader[7].ToString()}, {Reader[8].ToString()}");
                }
                return returnJobs;
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
        //Assign request 
        public void assignRequest()
        {
            throw new NotImplementedException();
        }
        public List<string> employeeAvailabe()
        {
            Connection();
            List<string> empAvaialbe = new List<string>();
            try
            {
                string getemp = $"Select EmployeeID,Name,Surname from Employee where Department = 'Service Department' and Availability = 'Yes';";
                Command = new System.Data.SqlClient.SqlCommand(getemp, Connection1);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    empAvaialbe.Add($"{Reader[0]} , {Reader[1]} , {Reader[2]} ");
                }
                return empAvaialbe;
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
        //Trackjob returns a status on job
        public List<string> TrackJobs(int jobID)
        {
            List<string> returnJobs = new List<string>();
            try
            {
                Connection();
                string jobs = $"select * from jobs where JobsID ={jobID}" ;
                Command = new System.Data.SqlClient.SqlCommand(jobs, Connection1);
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    returnJobs.Add($"{Reader[0].ToString()}, {Reader[1].ToString()}, {Reader[2].ToString()}, {Reader[3].ToString()}, {Reader[4].ToString()}, {Reader[5].ToString()}, {Reader[6].ToString()}, {Reader[7].ToString()}, {Reader[8].ToString()}");
                }
                return returnJobs;
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
        public void closeService(string jobid)
        {
            Connection();
            try
            {
                string closeRequest = $"update Jobs set Status = 'Done',DateEnded ='{DateTime.Now.ToString("MM/dd/yyyy")}' where JobsID = {jobid}";
                Command = new System.Data.SqlClient.SqlCommand(closeRequest, Connection1);
                Command.ExecuteNonQuery();
                MessageBox.Show("Job has been closed");
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
        public void reAssign(string empid,string job)
        {
            Connection();
            try
            {
                string update = $"update Jobs set EmployeeID = {empid} where JobsID = {job}";
                Command = new System.Data.SqlClient.SqlCommand(update,Connection1);
                Command.ExecuteNonQuery();
                MessageBox.Show("Job is now assigned to :" + empid);
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
        //Escalte jobs
        public void escaltejob(string jobID,string escalte)
        {
            Connection();
            try
            {
                string update = $"update Jobs set Priority = '{escalte}' where JobsID = {jobID}";
                Command = new System.Data.SqlClient.SqlCommand(update, Connection1);
                Command.ExecuteNonQuery();
                MessageBox.Show("Job is now escalted to : " + escalte);
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
    }
}
