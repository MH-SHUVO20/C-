using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
  
    
        class Programmer : Employee
        {
            private string programmingLanguage;
            private int yearsOfExperience;

            // Default constructor
            public Programmer() { }

            // Parameterized constructor
            public Programmer(string empNumber, string firstName, string lastName, string address, string programmingLanguage, int yearsOfExperience)
                : base(empNumber, firstName, lastName, address)
            {
                this.programmingLanguage = programmingLanguage;
                this.yearsOfExperience = yearsOfExperience;
            }

            public string ProgrammingLanguage
            {
                get { return programmingLanguage; }
                set { programmingLanguage = value; }
            }

            public int YearsOfExperience
            {
                get { return yearsOfExperience; }
                set { yearsOfExperience = value; }
            }

            // Method to display programmer details
            public override void DisplayEmployeeInfo()
            {
                base.DisplayEmployeeInfo();
                Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
                Console.WriteLine($"Years of Experience: {YearsOfExperience}");
            }
        }
    }


