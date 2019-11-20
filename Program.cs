using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carLot = new List<Car>();

            Car Ford = new Car("Ford", "Bronco", 80_000);
            Ford.Color = "pearl";
            // Ford.Make = "Ford";
            // Ford.Model = "Bronco";
            Ford.Year = 1986;
            // Ford.Mileage = 80_000;
            Ford.IsIspected = true;
            Ford.CountryOfOrigin = "Usa";

            Car Toyota = new Car("Toyota", "4Runner", 300)
            {
                // Make = "Toyota",
                // Model = "4Runner",
                Year = 2019,
                Color = "White",
                // Mileage = 300,
                IsIspected = false,
                CountryOfOrigin = "Japan"
            };

            Car Chevy = new Car("Chevy", "Malibu", 200_000)
            {
                // Make = "Chevy",
                // Model = "Malibu",
                Year = 1995,
                Color = "Red",
                // Mileage = 200_000,
                IsIspected = false,
                CountryOfOrigin = "Usa"
            };

            carLot.Add(Ford);
            carLot.Add(Toyota);
            carLot.Add(Chevy);

            Console.WriteLine($"The Bronco has {Ford.Mileage} miles");
            Ford.Drive();
            Console.WriteLine($"The Bronco has now {Ford.Mileage} miles after the drive test");
            Console.WriteLine(Ford.Description);
            Console.WriteLine(Toyota.Description);
            Toyota.Drive(3000);
            Console.WriteLine(Toyota.Description);
            Console.WriteLine(Chevy.Description);

        }
    }
}