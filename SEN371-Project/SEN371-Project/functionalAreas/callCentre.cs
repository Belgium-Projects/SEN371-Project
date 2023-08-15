using SEN371_Project.Connection;
using SEN371_Project.Data;
using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Twilio.TwiML.Voice;

namespace SEN371_Project.FunctionalAreas
{
    internal class callCentre : dataLog
    {
        //CRUD operations 
        private string starttime;
       
     public List<string> returnServices(string customerid)
        {
            Connection();
            List<string> returnService = new List<string>();
            try
            {
                string Service = $"select s.ServicesID,s.Task from Customer c inner join Packages p on c.PackagesID = p.PackagesID inner join ServiceinPackages sp on p.PackagesID = sp.packagesID inner join Service s on sp.ServicesID = s.ServicesID where CustomerID ={customerid}";
                Command = new SqlCommand(Service,Connection1);
                Reader = Command.ExecuteReader();
                while(Reader.Read())
                {
                    returnService.Add($"{Reader[0]} , {Reader[1]}");
                }
                return returnService;

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
        //save service JOB to db if employee is not linked will send sms to tech 
        public  void logJob(int customerID,int employeeid,string notes,string datestart , int servicesID,string priority)
        {
            try
            {
                string jobs;
                if (employeeid == 0)
                {
                    string customerinfo = $"Select name,Surname,Street,City from Customer where CustomerID = {customerID}";
                    string servicesinfo = $"Select ServicesID,Task,Description,ToolsMaterials,MaintancesType from Service where ServicesID ={servicesID}";
                    string message = "This job is not assignend or on anyones schedule pls see to it being fixed thank you details: ";
                    
                    API smsObject = new API();
                    jobs = $"Insert into Jobs(CustomerID,DateStarted,Notes,Priority,ServiceID,status)values({customerID},'{datestart}','{notes}','{priority}',{servicesID},'active');";
                    Connection();
                    Command = new SqlCommand(customerinfo, Connection1);
                    Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        message += $"Customer name = {Reader[0]} , Customer Surname =  {Reader[1]} , Customer address = {Reader[2]} {Reader[3]} ";
                    }
                    Disconnect();
                    Connection();
                    Command = new SqlCommand(servicesinfo, Connection1);
                    Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        message += $"Servies Info = ServiesID={Reader[0]} ,Task = {Reader[1]} ,Description = {Reader[2]} ,Toolsmaterials ={Reader[3]} ,MaintancesType = {Reader[4]} ";
                    }
                    Disconnect();
                    smsObject.smsAPIInvoke(message+$"Job: priortiy = {priority},notes = {notes} , datestart = {datestart} ");
                }
                else
                {
                 jobs  = $"Insert into Jobs(CustomerID,EmployeeID,DateStarted,Notes,Priority,ServiceID,status)values({customerID},{employeeid},'{datestart}','{notes}','{priority}',{servicesID},'active');";
                }
                Connection();
                Command = new System.Data.SqlClient.SqlCommand(jobs , Connection1);
                Command.ExecuteNonQuery();
                MessageBox.Show("Ticket saved ");
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
                    Services Service = new Services(int.Parse(Reader[1].ToString()), Reader[2].ToString(), Reader[3].ToString(),int.Parse( Reader[4].ToString()),int.Parse( Reader[5].ToString()), Reader[6].ToString(), Reader[7].ToString(), Reader[8].ToString());
                    return Service;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
              
            }
            return null;
           
        }
        //Return customer call logs
        public List<string> callHistory(int clientID)
        {
            //returns a calllog in this format customersid,customername+surname,employeeID,Employeename+surname+starttime,endtime,duration-in seconds 
            List<string> calllogs = new List<string>();
            string Calldetails = $"select * from InteractionHistory where CustomerID = {clientID}";
            Connection();
            try
            {
                
                Command = new System.Data.SqlClient.SqlCommand(Calldetails, Connection1);
                Reader = Command.ExecuteReader();
                while(Reader.Read())
                {
                    calllogs.Add($"{Reader[0]},{Reader[1]},{Reader[2]},,{Reader[3]},{Reader[4]},{Reader[5]},{Reader[6]}");
                }
                return calllogs;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
               
            }
            return null;
           
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

            }                //MessageBox.Show("Inserted");
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }
            
        }
        public override void saveToDB()
        {
            //This is a test 
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
        public bool isBusinessCustomer(int clientID)
        {
            try
            {

                string businessCheck = $"Select count(customerID) from BusinessCustomer where CustomerID ={clientID}";
                Connection();
                Command = new System.Data.SqlClient.SqlCommand(businessCheck, Connection1);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    if (int.Parse(Reader[0].ToString()) == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                Disconnect();
                return false;
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
        public override List<client> selectFromDB(int clientID)
        {
           
            List<client> CustomerInfo = new List<client>();
            try
            {
                if (isBusinessCustomer(clientID))
                {
                    //Is a business CLient 
                    Connection();
                    string getRep = $"Select * from BusinessRole br inner join BusinessCustomer bc on br.BusinessRoleID = bc.BusinessRoleID where CustomerID ={clientID}";
                    Command =new SqlCommand(getRep, Connection1);
                    Reader = Command.ExecuteReader();
                    List<string> businessRep = new List<string>();
                    while (Reader.Read())
                    {
                        businessRep.Add($"{Reader[0]},{Reader[1]},{Reader[2]},{Reader[3]},{Reader[4]}");
                        
                    }
                    Disconnect();
                    Connection();
                    string getclientInfo = $"Select * from customer where CustomerID ={clientID}";
                    Command = new SqlCommand(getclientInfo, Connection1);
                    Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        CustomerInfo.Add(new client(Reader[2].ToString(), businessRep, Reader[4].ToString(), Reader[0].ToString()));
                    }
                    Disconnect();
                    return CustomerInfo;
                }
                else
                {
                    //Returns individula person
                    Connection();
                    string getclientInfo = $"Select * from customer where CustomerID ={clientID}";
                    Command = new SqlCommand(getclientInfo, Connection1);
                    Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        CustomerInfo.Add(new client(Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString(), Reader[0].ToString())); ;
                    }
                    Disconnect();
                    return CustomerInfo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }
          
            return null;
        }
    }
}
