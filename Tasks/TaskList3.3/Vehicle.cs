using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList3._3
{
    public class Vehicle
    {
        public string Model { get; set; }
        public string Year { get; set; }
        public double FuelCapacity { get; set; }
        public Vehicle(string model, string year, double fuelCapacity)
        {
            this.Model = model;
            this.Year = year;
            this.FuelCapacity = fuelCapacity;
        }
        public virtual void Drive()
        {
            Console.WriteLine("The vehicle is moving");
        }
        public virtual void Refuel(double fuel)
        {
            FuelCapacity += fuel;
        }
    }
}
