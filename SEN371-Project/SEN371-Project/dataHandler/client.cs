using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project.dataHandler
{
    internal class client
    {
       private string cusName;
       private string cusSurname;
       private string cusService;
       private string cusBussinessName;
       private string cusRepresentativeName;
       private string cusPhonenumber;
       private string cusID;

        public client(string cusName, string cusSurname, string cusService, string cusPhonenumber, string cusID)
        {
            this.cusName = cusName;
            this.cusSurname = cusSurname;
            this.cusService = cusService;
            this.cusPhonenumber = cusPhonenumber;
            this.cusID = cusID;
        }
        public client(string cusBussinessName, string cusRepresentativeName, string cusPhonenumber, string cusID)
        {
            this.cusBussinessName = cusBussinessName;
            this.cusRepresentativeName = cusRepresentativeName;
            this.cusPhonenumber = cusPhonenumber;
            this.cusID = cusID;
        }
        public string CusName { get => cusName; set => cusName = value; }
        public string CusSurname { get => cusSurname; set => cusSurname = value; }
        public string CusService { get => cusService; set => cusService = value; }
        public string CusBussinessName { get => cusBussinessName; set => cusBussinessName = value; }
        public string CusRepresentativeName { get => cusRepresentativeName; set => cusRepresentativeName = value; }
        public string CusPhonenumber { get => cusPhonenumber; set => cusPhonenumber = value; }
    }
}
