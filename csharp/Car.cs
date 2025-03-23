using System;

namespace csharp
{
    public class Car
    {
        private string color = "Blue";
    
        public static void DisplayCar()
        {
            Car car = new Car();
            Console.WriteLine(car.color);
        }
    }
}
