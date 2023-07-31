using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Resource for REST API for powerbi 
//https://github.com/microsoft/PowerBI-CSharp

namespace SEN371_Project.Connection
{
    internal class API : employee
    {
        string ResourceURL;
        string accessToken;
        string tokenCredentials;
        string applicationID;

        //establish connection
        public void Startup()
        {
            throw new NotImplementedException();
        }
        //Gets access token of the employee
        public void GetAccessToken(int employeeID)
        {
            throw new NotImplementedException();
        }
        //Configure api service
        public void configureServices()
        {
            throw new NotImplementedException();
        }
        //Returns the key preformance of a employees preformes get action with api
        public string kpis(int employeeID)
        {
            throw new NotImplementedException();
        }
        public API(string empName, string empId, string empSurname, string empRole) : base(empName, empId, empSurname, empRole)
        {

        }
        string connectionString;
        //Encapsulation 
        public string ResourceURL1 { get => ResourceURL; set => ResourceURL = value; }
        public string AccessToken { get => accessToken; set => accessToken = value; }
        public string TokenCredentials { get => tokenCredentials; set => tokenCredentials = value; }
        public string ApplicationID { get => applicationID; set => applicationID = value; }
    }
}
