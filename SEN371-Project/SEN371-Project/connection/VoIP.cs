using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project.Connection
{
    internal class VoIP
    {
        string displayName;
        string userName;
        string registerName;
        string password;
        int domain;
        string outboundProxy;

        public string DisplayName { get => displayName; set => displayName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string RegisterName { get => registerName; set => registerName = value; }
        public string Password { get => password; set => password = value; }
        public int Domain { get => domain; set => domain = value; }
        public string OutboundProxy { get => outboundProxy; set => outboundProxy = value; }

        public void startService() { 
        }
        public void stopService() { }
        public void Startcall() { }
        public void Stopcall() { }
        public void Redirectcall()
        {

        }
    }
}
