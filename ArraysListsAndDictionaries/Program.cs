using System;
using System.Collections.Generic;

namespace ArraysListsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var fordFiesta = new Car("Ford", "Fiesta", 2013);
            var subaruLegacy = new Car("Subaru", "Legacy", 2017);
            var hondaCRV = new Car("Honda", "CRV", 2014);

            // Array
            var parkedCars = new Car[5];
            Console.WriteLine(parkedCars.Length);
            parkedCars[0] = hondaCRV;

            var firstCar = parkedCars[0];

            Console.WriteLine(firstCar.Make);



            // List
            // Examples
            var foo = new List<string>();
            foo.Add("1");

            var bar = new List<int>();
            bar.Add(1);

            // List of Luxury Cars
            var luxuryCars = new List<Car>();

            // Add to specific spot
            luxuryCars[0] = hondaCRV;

            // Add to next spot
            luxuryCars.Add(hondaCRV);


            var firstLuxuryCar = luxuryCars[0];

            Console.WriteLine(firstLuxuryCar);

            

            //
            Console.ReadLine();
        }
    }
}
