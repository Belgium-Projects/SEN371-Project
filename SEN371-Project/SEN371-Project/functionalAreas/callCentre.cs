using SEN371_Project.Connection;
using SEN371_Project.Data;
using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project.FunctionalAreas
{
    internal class callCentre : dataLog
    {
        //CRUD operations 
        private string starttime;
     
        //save service ticket to db
        public  void saveDatata(int customerID,string notes,string datestart , int servicesID,int priority)
        {
            Connection();
            string jobs = $"insert into Jobs(CustomerID,Notes,status,DateStarted,ServiceID,Priority) values({customerID},'{notes}','Not yet started','{datestart}',{servicesID},'{priority}');";
            try
            {
                Command = new System.Data.SqlClient.SqlCommand(jobs , Connection1);
                Command.ExecuteNonQuery();
                MessageBox.Show("Ticket saved ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Disconnect();
        }
        //View customer agreement
        public Services cusAgreement(int id)
        {
            Connection();
            string custom = $"select * from cusAgreement where CustomerID = {id}";
           
            try
            {
                Command = new System.Data.SqlClient.SqlCommand(custom,Connection1);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Services s = new Services(int.Parse(Reader[1].ToString()), Reader[2].ToString(), Reader[3].ToString(),int.Parse( Reader[4].ToString()),int.Parse( Reader[5].ToString()), Reader[6].ToString(), Reader[7].ToString(), Reader[8].ToString());
                    return s;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Disconnect();
            return null; 
        }
        //Return customer call logs
        public List<string> callHistory(int id)
        {
            //returns a calllog in this format customersid,customername+surname,employeeID,Employeename+surname+starttime,endtime,duration-in seconds 
            List<string> calllogs = new List<string>();
            string Calldetails = $"select * from InteractionHistory where CustomerID = {id}";
            Connection();
            try
            {
                
                Command = new System.Data.SqlClient.SqlCommand(Calldetails, Connection1);
                Reader = Command.ExecuteReader();
                while(Reader.Read())
                {
                    calllogs.Add($"{Reader[0]},{Reader[1]},{Reader[2]},,{Reader[3]},{Reader[4]},{Reader[5]},{Reader[6]}");
                }
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Disconnect();
            return calllogs;
        }
      
        //anwsers call
        public string anwsercall()
        {
            this.starttime = DateTime.Now.ToString();
            
            return starttime;
        }
        // end call
        public void endCall(int customerID, int employeeid)
        {
            string insert = $"insert into CallHistory(CustomerID,StartTime,Endtime,EmployeeID) values({customerID},'{starttime}','{DateTime.Now}',{employeeid})";
            Connection();
            try
            {
                Command = new System.Data.SqlClient.SqlCommand(insert,Connection1);
                Command.ExecuteNonQuery();
                MessageBox.Show("Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void saveToDB()
        {
            throw new NotImplementedException();
        }

        public override void deleteFromDB()
        {
            throw new NotImplementedException();
        }

        public override void updateFromDB()
        {
            throw new NotImplementedException();
        }

        public override List<client> selectFromDB()
        {
            throw new NotImplementedException();
        }
    }
}
