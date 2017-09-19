using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("\n Greetings user, please enter an employee name: ");
            string newEmployee = Console.ReadLine();

            employee.EmployeeName = newEmployee;

            Console.Write("\n Please enter a start date: ");
            DateTime hireDate = DateTime.Parse(Console.ReadLine());
            employee.HireDate = hireDate;

            employee.GetDateTime();

            /*Console.WriteLine($"\n Employee Name: {employee.EmployeeName}");*/ //Testing outupt
            Console.WriteLine($"\n Employee Start Date: {employee.HireDate}\n"); //Testing outupt
        }
    }
}
