using SEN371_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project.dataHandler
{
 
    internal  class employee :dataLog
    {
           
      public static string empName;
        public string empId;
        public string empSurname;
        public string empRole;
        public string empPhoneNumber;
        public string empUsername;
        public string empPassword;
         private string HashedPassword;

        //public employee(string empName, string empId, string empSurname, string empRole, string empPhoneNumber,string empUsername, string empPassword)
        //{
        //    this.empName = empName;
        //    this.empId = empId;
        //    this.empSurname = empSurname;
        //    this.empRole = empRole;
        //    this.empPhoneNumber = empPhoneNumber;
        //    this.empUsername = empUsername;
        //    this.empPassword = empPassword;

        //}
        public  string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] saltedPassword = Encoding.UTF8.GetBytes(password + "123");
                byte[] hashBytes = sha256.ComputeHash(saltedPassword);
                return Convert.ToBase64String(hashBytes);
            }
            
        }
       
        public bool ValidateCredentials(string username, string password)
        {
            bool flag = false;
            try
            {
                Connection();
                string hashedPass = HashPassword(password);
               
                string getAccountInfo = $"Select * from Employee where Username = '{username}' and Password = '{hashedPass}';";
               
           
                Command = new System.Data.SqlClient.SqlCommand(getAccountInfo, Connection1);
                Reader = Command.ExecuteReader();
                while(Reader.Read())
                {
                   
                    if (Reader[12].ToString() == username && Reader[13].ToString() == hashedPass)
                    {
                        //MessageBox.Show(Reader[0].ToString() + "=" + username + ',' + Reader[1].ToString() + "=" + hashedPass);
                        //MessageBox.Show("YEah");
                        empName = Reader[3].ToString();

                         flag = true;
                    }
                    else
                    {

                        MessageBox.Show(Reader[0].ToString()+"="+ username + ',' + Reader[1].ToString()+"="+hashedPass);
                        flag = false;
                    }
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
            return flag;
        }

        // Helper method to hash the password with salt
     
        //Checks if employee can access function
        bool canAcces(int empRole, string RoleNeeded)
        {
            return true;
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

        public override List<client> selectFromDB(int client)
        {
            throw new NotImplementedException();
        }

        public string EmpName { get => empName; set => empName = value; }
        public string EmpId { get => empId; set => empId = value; }
        public string EmpSurname { get => empSurname; set => empSurname = value; }
        public string EmpRole { get => empRole; set => empRole = value; }
        public string Username { get; private set; }
        public string Salt { get; private set; }
    }
}
