using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public abstract class Vehicle
    {
        private string name;
        public string Name { get; set; }

        public Vehicle(string name)
        {
            Name = name;
        }

        public abstract double CalculateSpeed();
    }
}
