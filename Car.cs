using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Exercise
{
    public class Car
    {
        //public Car()
        //{

        //}

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public string ShowCarDetails()
        {
            return $"Make: {Make}\n" +
                    $"Model: {Model}\n" +
                    $"Year: {Year}\n";
        }

    }
}
