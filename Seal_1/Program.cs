using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seal_1
{
    public class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }

    public sealed class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }

    // This will result in a compilation error because you cannot inherit from a sealed class.
   /* public class ChildCar : Car
    {
        public void SomeMethod()
        {
            Console.WriteLine("This will not work.");
        }
    }*/

    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.StartEngine();
            myCar.Drive();
            myCar.StopEngine();
        }
    }
}
