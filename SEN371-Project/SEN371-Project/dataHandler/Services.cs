using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project.dataHandler
{
    internal class Services : client
    {
        //info needed for service agreement
        private int ackageNumber;
        private string packageName;
        private string packageexpiredate;
        private string notes;

        //client constructor 
        public Services(string cusName, string cusSurname, string cusService, string cusPhonenumber, string cusID) : base(cusName, cusSurname, cusService, cusPhonenumber, cusID)
        {
        }
        public Services(string cusBussinessName, string cusRepresentativeName, string cusPhonenumber, string cusID) : base(cusBussinessName, cusRepresentativeName, cusPhonenumber, cusID)
        {
        }

    }
}
