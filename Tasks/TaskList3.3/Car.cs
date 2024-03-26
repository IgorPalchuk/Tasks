using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList3._3
{
    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public Car(string model, string year, double fuelCapacity , int numberOfWheels) : base(model , year , fuelCapacity)
        {
            this.NumberOfWheels = numberOfWheels;
        }
        public override void Drive()
        {
            Console.WriteLine("The car is moving");
        }
        public override void Refuel(double fuel)
        {
           base.Refuel(fuel);
        }
    }
}
