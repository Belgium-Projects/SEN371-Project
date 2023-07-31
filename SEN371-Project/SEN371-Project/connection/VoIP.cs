using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project.Connection
{
    internal class VoIP:databaseCon
    {
       private string displayName;
       private string userName;
       private string registerName;
       private string password;
       private int domain;
       private string outboundProxy;

        public string DisplayName { get => displayName; set => displayName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string RegisterName { get => registerName; set => registerName = value; }
        public string Password { get => password; set => password = value; }
        public int Domain { get => domain; set => domain = value; }
        public string OutboundProxy { get => outboundProxy; set => outboundProxy = value; }
        //Start servies so one can recive calls
        public void startService() {
            throw new NotImplementedException();
        }
        //stops services
        public void stopService() {
            throw new NotImplementedException();
        }
        //anwers call saves start time in database
        public void Startcall() {
            throw new NotImplementedException();
        }
        //Ends calls saves the details about end call in db
        public void Stopcall() {
            throw new NotImplementedException();
        }
        //changes end of call
        public void Redirectcall()
        {
            throw new NotImplementedException();
        }
    }
}
