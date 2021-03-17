using System;
using System.Collections.Generic;

namespace Class_Exercise
{
    public class Program
    {
        public string MyField;

        internal int MyProperty { get; set; }


        static void Main(string[] args)
        {
            var list = new List<int>();

            Car c1 = new Car("Toyota", "4Runner", 2021);


            Console.WriteLine(c1.ShowCarDetails());





        }
    }
}
