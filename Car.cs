using System;

namespace autoService
{
    class Car : Vehicle
    {
        public Car(string nameOfCar, string model, string nameOfEngine, double volumeOfEngine, string nameOfWheel) 
            : base(nameOfCar, model, nameOfEngine, volumeOfEngine, nameOfWheel)
        {
            
        }

        public override void Print()
        {
            Console.WriteLine($"You drive a car\nThe characteristics of your car :\n" +
                $"Name:\t\t\t{nameOfCar}\nModel:\t\t\t{model}\nEngine:\t\t\t{nameOfEngine}\n" +
                $"Engine's volume:\t{volumeOfEngine}\nWheel Type:\t\t{nameOfWheel}");
        }

    }
}
