using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public class Car : Vehicle
    {
        public double FixedSpeed {  get; set; }
        public Car(string name, double fixedSpeed): base(name)
        {
            FixedSpeed = fixedSpeed;
        }
        public override double CalculateSpeed()
        {
           return FixedSpeed;
        }
    }
}
