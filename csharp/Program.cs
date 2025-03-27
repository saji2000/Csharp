using System;

namespace csharp
{
    class Program{
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            
            Car car2 = new Car(carBrand: "Tesla", carModel: "S3", carYear: 2016);
            car2.DisplayCar();

            car2.Brand = "BYD";
            
            Console.WriteLine(car2.Brand);
            car2.DisplayType();
            
            Console.WriteLine(car.Type);
            
            car2.MakeSound();
            car.MakeSound();
        }
    }
}

