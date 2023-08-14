using SEN371_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project.dataHandler
{
    internal  class employee :dataLog
    {
           
        string empName;
        string empId;
        string empSurname;
        string empRole;
        string empPhoneNumber;
        string empUsername;
        string empPassword;
        private string HashedPassword;

        public employee(string empName, string empId, string empSurname, string empRole, string empPhoneNumber,string empUsername, string empPassword)
        {
            this.empName = empName;
            this.empId = empId;
            this.empSurname = empSurname;
            this.empRole = empRole;
            this.empPhoneNumber = empPhoneNumber;
            this.empUsername = empUsername;
            this.empPassword = empPassword;

        }

        public bool ValidateCredentials(string username, string password)
        {
            if (username == Username && HashPassword(password, Salt) == HashedPassword)
            {
                return true;
            }
            return false;
        }

        // Helper method to hash the password with salt
        private static string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] saltedPassword = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(saltedPassword);
                return Convert.ToBase64String(hashBytes);
            }
        }

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
