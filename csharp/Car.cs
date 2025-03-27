using System;

namespace csharp
{
    class Car : Vehicle
    {
        private string brand;
        private string model;
        private int year;
        
        public Car(string carBrand = "Toyta", string carModel = "Corolla", int carYear = 2025)
        {
            brand = carBrand;
            model = carModel;
            year = carYear;
            Type = "Land";
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public void DisplayCar()
        {
            Console.WriteLine($"The car's brand is: {brand} and the model is : {model} {year}");
        }

        private void CarPrice()
        {
            Console.WriteLine("50,000");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Honk Honk!");
        }
    }
}
