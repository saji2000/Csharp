using System;

namespace csharp
{
    class Program{
        static void Main(string[] args)
        {
            Car car = new Car();
            car.DisplayCar();
            
            Car car2 = new Car(carBrand: "Tesla", carModel: "S3", carYear: 2016);
            car2.DisplayCar();
        }
    }
}

