using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
// Resource for REST API for powerbi 
//https://github.com/microsoft/PowerBI-CSharp

namespace SEN371_Project.Connection
{
    internal class API 
    {

        string resourceURL;
         string accessToken= "ACd526795df293545a79b4b8eba0ad52d4";
         string tokenCredentials = "6eb99d5e0edf6ace80614ab6223fb68c";
         string employeePhone = "+27818150525";
        string applicationID;
        //Sends info to the employee if job not assigned
        public void smsAPIInvoke(string messagesend)
        {
            try
            {
                ////Token and Credentials
                //TwilioClient.Init(accessToken, tokenCredentials);
                ////API info Header and body
                //var messageOptions = new CreateMessageOptions(
                //  new PhoneNumber(employeePhone));
                //messageOptions.From = new PhoneNumber("+13135138498");
                //messageOptions.Body = messagesend;
                ////invoke API 
                //var message = MessageResource.Create(messageOptions);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //establish connection
        public void Startup()
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
        //public API(string empName, string empId, string empSurname, string empRole) : base(empName, empId, empSurname, empRole)
        //{

        //}
        string connectionString;





        //Encapsulation 
        public string ResourceURL { get => resourceURL; set => resourceURL = value; }
        public string AccessToken { get => accessToken; set => accessToken = value; }
        public string TokenCredentials { get => tokenCredentials; set => tokenCredentials = value; }
        public string ApplicationID { get => applicationID; set => applicationID = value; }
    }
}
