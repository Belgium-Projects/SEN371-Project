using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project.dataHandler
{
    internal  class employee
    {
        string empName;
        string empId;
        string empSurname;
        string empRole;

        public employee(string empName, string empId, string empSurname, string empRole)
        {
            this.empName = empName;
            this.empId = empId;
            this.empSurname = empSurname;
            this.empRole = empRole;
        }
        
        //Checks if employee can access function
         bool canAcces(int empRole, string RoleNeeded)
        {
            return true;
        }
        public string EmpName { get => empName; set => empName = value; }
        public string EmpId { get => empId; set => empId = value; }
        public string EmpSurname { get => empSurname; set => empSurname = value; }
        public string EmpRole { get => empRole; set => empRole = value; }
    }
}
