using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Employee
    {
        private DateTime hireDate;
        private string employeeName;

        public string EmployeeName { get; set; }
        public DateTime HireDate { get; set; }

        public TimeSpan GetDateTime()
        {
            TimeSpan timeAtCompany = (DateTime.Now - HireDate);
            Console.WriteLine($"\n This employee has worked for the company {timeAtCompany.Days} days.\n");
            return timeAtCompany;
        }
    }
}
