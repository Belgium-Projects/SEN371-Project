using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project.dataHandler
{
    internal class Jobs
    {
        string jobID, customerID, employeeID,ServicesID;
        string notes, status, Datestarted, dataEnd, Priortiy;

        public Jobs(string jobID, string customerID, string employeeID, string servicesID, string notes, string status, string datestarted, string dataEnd, string priortiy)
        {
            this.jobID = jobID;
            this.customerID = customerID;
            this.employeeID = employeeID;
            ServicesID = servicesID;
            this.notes = notes;
            this.status = status;
            Datestarted = datestarted;
            this.dataEnd = dataEnd;
            Priortiy = priortiy;
        }
    }
}
