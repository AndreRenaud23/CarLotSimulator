﻿using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //DONE ^

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            //Porsche 911 Targa 4 GTS 2023 $162,700
            //2023 Chevrolet Corvette Z06 has a starting price of $106,395
            //Mclaren, the speedtail starting price 2,100,000 est. 2018


            var car1 = new Car();
            CarLot CarLot1 = new CarLot();

            CarLot1.CarList.Add(car1);
            car1.Make = "Porsche";
            car1.Model = "911 Targa 4 GTS";
            car1.Year = "2023";
            car1.Price = "$162,700";
            car1.Recommendation = "Yes";
            car1.IsDrivable = "Yes";
            car1.HonkNoise = "Normal";
            car1.EngineNoise = "Loud";

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Start");
            Console.WriteLine("------------------------------------------------------------");

            car1.PrintStuff();

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("NEXT CAR");
            Console.WriteLine("------------------------------------------------------------");



            var car2 = new Car();
            CarLot CarLot2 = new CarLot();

            CarLot2.CarList.Add(car2);
            {
                car2.Make = "Chevrolet Corvette";
                car2.Model = "Z06";
                car2.Year = "2023";
                car2.Price = "$106,395";
                car2.Recommendation = "Yes";
                car2.IsDrivable = "Yes";
                car2.HonkNoise = "Normal";
                car2.EngineNoise = "Loud";

                car2.PrintStuff();

                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("NEXT CAR");
                Console.WriteLine("------------------------------------------------------------");

            }

           

            var car3 = new Car( "Mclaren", "The Speedtail", "2018", "$2,250,000 est.", "No, unless your filthy rich! lol :)", "Yes", "Normal", "Loud");

            CarLot CarLot3 = new CarLot();

            CarLot3.CarList.Add(car3);
            foreach (var car in CarLot3.CarList)
            {
                car.PrintStuff();

            }

            Console.WriteLine();
            Console.WriteLine($"Number of cars in the lot: {CarLot.numberOfCars}");
            Console.WriteLine();




            //OR


            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Finish 'ps: now your a little bit smarter :)'  ");
            Console.WriteLine("------------------------------------------------------------");


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            // #1

            // ABOVE
            
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
