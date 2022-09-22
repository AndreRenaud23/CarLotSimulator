using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {

        }

        public Car(string make, string model, string year, string price, string recommendation, string isdrivable, string honknoise, string enginenoise)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Recommendation = recommendation;
            IsDrivable = isdrivable;
            HonkNoise = honknoise;
            EngineNoise = enginenoise;
        }

        public string Make { get; set; }
        

        public string Model { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
        public string Recommendation { get; set; }
        public string Isdrivable { get; }
        public string IsDrivable { get; set; }
        public string Honknoise { get; }
        public string HonkNoise { get; set; }
        public string Enginenoise { get; }

        public void makeHonkNoise(string noise)
        {
            Console.WriteLine(noise);
        }
        public string EngineNoise { get; set; }
        
        public void makeEngineNoise(string noise)
        {
            Console.WriteLine(noise);
        }

        public void PrintStuff()
        {
            Console.WriteLine($"Brand: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Recommendation status: {Recommendation}");
            Console.WriteLine($"Is the car drivable: {IsDrivable}");
            Console.WriteLine($"Honk noise: {HonkNoise}");
            Console.WriteLine($"Engine noise: {EngineNoise}");
        }


    }
}
