using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project.dataHandler
{
    internal class Services 
    {
        //info needed for service agreement
        private int CustomerID;
        private int PackagesID;
        private string packageName;
        private string Availability;
        private decimal dicount;
        private int SLAID;
        private string packageexpiredate;
        private string StartDate;
        private string Status;

        public Services(int packagesID, string packageName, string availability, decimal dicount, int sLAID, string packageexpiredate, string startDate, string status)
        {
            PackagesID = packagesID;
            this.packageName = packageName;
            Availability = availability;
            this.dicount = dicount;
            SLAID = sLAID;
            this.packageexpiredate = packageexpiredate;
            StartDate = startDate;
            Status = status;
        }



        //client constructor 


    }
}
