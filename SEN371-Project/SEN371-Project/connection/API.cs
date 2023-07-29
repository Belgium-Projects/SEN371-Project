using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SEN371_Project.Connection
{
    internal class API : Employee
    {
        string ResourceURL;
        string accessToken;
        string tokenCredentials;
        string applicationID;

        // Resource for REST API for powerbi 
        //https://github.com/microsoft/PowerBI-CSharp
        public void Startup()
        {

        }
        public void GetAccessToken()
        {
           
        }
        public void configureServices()
        {

        }
        public API(string empName, string empId, string empSurname, string empRole) : base(empName, empId, empSurname, empRole)
        {
        }
        string connectionString;

        public string ResourceURL1 { get => ResourceURL; set => ResourceURL = value; }
        public string AccessToken { get => accessToken; set => accessToken = value; }
        public string TokenCredentials { get => tokenCredentials; set => tokenCredentials = value; }
        public string ApplicationID { get => applicationID; set => applicationID = value; }
    }
}
