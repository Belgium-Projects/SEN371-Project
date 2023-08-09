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

namespace SEN371_Project.FunctionalAreas
{
    internal class callCentre : dataLog
    {
        //CRUD operations 
        private string starttime;
     
        //save service ticket to db
        public  void logTicket(int customerID,int employeeid,string notes,string datestart , int servicesID,int priority)
        {
            Connection();
            string jobs = $"Insert into Jobs(CustomerID,EmployeeID,DateStarted,Notes,Priority,ServiceID,status)values({customerID},{employeeid},'{datestart}','{notes}','{priority}',{servicesID},'active');";
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
