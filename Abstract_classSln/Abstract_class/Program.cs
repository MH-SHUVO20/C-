using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Lamborgini", 200);
            Console.WriteLine($"Car: {car.Name}, Speed :{car.CalculateSpeed()} km/h");

            Bike bike = new Bike("4V", 150, 200);
            Console.WriteLine($"Bike:{bike.Name}, Speed: {bike.CalculateSpeed()} km/h");
        }
    }
}
