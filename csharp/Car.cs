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
            Console.WriteLine($"The car's brand is: {brand} and the model is : {model} {year}");
        }

        private void CarPrice()
        {
            Console.WriteLine("50,000");
        }
    }
}
