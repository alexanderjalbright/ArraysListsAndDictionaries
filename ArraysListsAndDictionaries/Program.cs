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

            //**********************************************************************************************
            // Array
            var parkedCars = new Car[5];
            Console.WriteLine(parkedCars.Length);
            parkedCars[0] = hondaCRV;

            var firstCar = parkedCars[0];

            Console.WriteLine(firstCar.Make);



            //**********************************************************************************************
            // List
            // Examples
            var foo = new List<string>();
            foo.Add("1");

            var bar = new List<int>();
            bar.Add(1);

            // List of Luxury Cars
            var luxuryCars = new List<Car>();

            

            // Add to next spot
            luxuryCars.Add(hondaCRV);

            // Add to specific spot if spot already exists
            luxuryCars[0] = hondaCRV;
            luxuryCars.Insert(0,hondaCRV);


            var firstLuxuryCar = luxuryCars[0];

            Console.WriteLine(firstLuxuryCar);
            
            for (int i = 0; i < luxuryCars.Count; i++)
            {
                var currentCar = luxuryCars[i];
                Console.WriteLine(currentCar.Make);
            }
            
            // "foreach" does the same as for loop to a List
            foreach(var currentCar in luxuryCars)
            {
                Console.WriteLine(currentCar.Make);
            }

            // Making object Examples
            var carMakers = new List<string>();
            carMakers.Add("Ford");
            carMakers.Add("Chevy");
            carMakers.Add("Kia");

            var carMakers2 = new List<string>()
            {
                "Ford",
                "Chevy",
                "Kia"
            };

            var carMakers3 = new List<Car>()
            {
                new Car("Chevy", "Camaro", 1965),
                new Car("Chevy", "Volt", 2015)
                {
                    MilesPerGallon = 12
                }
            };






            //**********************************************************************************************
            // Dictionaries

            var students = new Dictionary<int, string>();
            students.Add(1, "Nate");
            students.Add(2, "Maya");

            int scannedStudentId = 2;
            var maya = students[scannedStudentId];

            var configuration = new Dictionary<string, bool>()
            {
                {"AutoSave", true },
                {"DarkMode", true }
            };

            var shouldIAutoSave = configuration["AutoSave"];

            Console.WriteLine(shouldIAutoSave);

            foreach(var setting in configuration)
            {
                Console.WriteLine(setting.Key + ": " + setting.Value);
            }
            Console.ReadLine();

            var phoneBook = new Dictionary<string, long>()
            {
                {"Alex Albright", 3307349959 },
                {"Jenny", 3308675309 },
                {"Joe Shmoe", 5555555 }
            };

            string choice = Console.ReadLine();

            Console.WriteLine(phoneBook[choice]);
        }
    }
}
