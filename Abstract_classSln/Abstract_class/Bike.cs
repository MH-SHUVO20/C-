using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public class Bike : Vehicle
    {
        public double EnginePower {  get; set; }
        public double Weight { get; set; }
        public Bike(string name,double enginePower,double weight) : base (name)
        {
            this.EnginePower = enginePower;
            this.Weight = weight;

        }
        public override double CalculateSpeed()
        {
            return EnginePower / Weight * 100;
        }
    }
}
