using System;

namespace autoService
{
    abstract class Vehicle
    {
        protected string nameOfCar { get; set; }
        protected string model { get; set; }
        protected string nameOfEngine { get; set; }
        protected double volumeOfEngine { get; set; }
        protected string nameOfWheel { get; set; }

        public Vehicle(string nameOfCar, string model, string nameOfEngine, double volumeOfEngine, string nameOfWheel)
        {
            this.nameOfCar = nameOfCar;
            this.model = model;
            this.nameOfEngine = nameOfEngine;
            this.volumeOfEngine = volumeOfEngine;
            this.nameOfWheel = nameOfWheel;
        }

        public virtual void Print()
        {
            Console.WriteLine("You drive a vehicle");
        }
    }
}
