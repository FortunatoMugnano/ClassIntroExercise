using System;

namespace ClassIntro
{
    class Car
    {

        //Fields, similar to proprieties but they are typically private
        //Don't specify get and set!
        private string _vinNumber;

        private int _standardTestDrive = 5;

        //Constructor
        public Car(string make, string model, int mileage)
        {
            Make = make;
            Model = model;
            Mileage = mileage;

            Random rand = new Random();
            _vinNumber = rand.Next(10_000, 1_000_000).ToString();
        }

        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public int Mileage { get; private set; }
        public string Color { get; set; }
        public string CountryOfOrigin { get; set; }
        public bool IsIspected { get; set; }
        public string Description
        {
            get
            {
                return $"{Year} {Make} {Model} with {Mileage} miles";
            }
        }

        //Methods
        public void Drive(int milesDriven)
        {
            Mileage += milesDriven;
        }

        //Overloading the Method
        public void Drive()
        {
            Mileage += _standardTestDrive;
        }

    }
}