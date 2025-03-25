using System;

namespace csharp
{
    public class Car
    {
        public string brand;
        public string model;
        public int year;

        public Car(string carBrand = "Toyta", string carModel = "Corolla", int carYear = 2025)
        {
            brand = carBrand;
            model = carModel;
            year = carYear;
        }
    
        public void DisplayCar()
        {
            Car car = new Car();
            Console.WriteLine($"The car's brand is: {car.brand} and the model is : {car.model} {car.year}");
        }
    }
}
