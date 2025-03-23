using System;

namespace csharp
{
    public class Car
    {
        private string color = "Blue";
        private int maxSpeed = 100;
    
        public static void DisplayCar()
        {
            Car car = new Car();
            Console.WriteLine($"The car's color is: {car.color} and the max speed is : {car.maxSpeed} km/hr");
        }
    }
}
