using System;

namespace Inheritance
{
    class Manager : Employee
    {
        private char payRateIndicator;
        private Employee[] emps;

        // Default constructor
        public Manager() { }

        // Parameterized constructor
        public Manager(string empNumber, string firstName, string lastName, string address, char payRateIndicator, Employee[] emps)
            : base(empNumber, firstName, lastName, address)
        {
            this.payRateIndicator = payRateIndicator;
            this.emps = emps;
        }

        public char PayRateIndicator
        {
            get { return payRateIndicator; }
            set { payRateIndicator = value; }
        }

        public Employee[] Emps
        {
            get { return emps; }
            set { emps = value; }
        }

        // Method to display manager details
        public override void DisplayEmployeeInfo()
        {
            base.DisplayEmployeeInfo();
            Console.WriteLine($"Pay Rate Indicator: {PayRateIndicator}");
            Console.WriteLine("Managed Employees:");
            if (emps != null)
            {
                foreach (var emp in emps)
                {
                    emp.DisplayEmployeeInfo();
                }
            }
        }
    }
}
