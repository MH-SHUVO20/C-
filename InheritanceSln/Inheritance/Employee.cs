using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee
    {
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;
       //Default Constructor
        public Employee()
        {

        }
        //Perameterized Constructor
        public Employee(string empNumber, string firstName, string lastName, string address)
        {
            this.empNumber = empNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
        }
        public string EmpNumber
        {
            get { return empNumber; }
            set { empNumber = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public virtual void  DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee Number: {EmpNumber}");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}
