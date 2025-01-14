
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee instance
            Employee employee = new Employee("E01", "MH", "SHUVO", "Garagonj,Shailkupa,Jhenaidah");
            employee.DisplayEmployeeInfo();
            Console.WriteLine();

            // Create a Programmer instance
            Programmer programmer = new Programmer("P01", "MI", "SHIAM", "KURIGRAM", "C#", 5);
            programmer.DisplayEmployeeInfo();
            Console.WriteLine();

            // Create a Manager instance
            Employee[] managedEmployees = { employee, programmer };
            Manager manager = new Manager("M01", "TOPU", "Barua", "Bogura", 'A', managedEmployees);
            manager.DisplayEmployeeInfo();

            Console.ReadLine();
        }
    }
}
