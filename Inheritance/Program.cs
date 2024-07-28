using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird myBird = new Bird();
            myBird.Name = "Parrot";
            myBird.Age = 2;
            myBird.Color = "Green";
            myBird.NumberOfLegs = 2;
            myBird.WingSpan = 25;
            myBird.CanFly = true;
            myBird.BeakLength = 2;
            myBird.FavoriteFood = "Seeds";

            Console.WriteLine("Bird Details:");
            Console.WriteLine($"Name: {myBird.Name}");
            Console.WriteLine($"Age: {myBird.Age}");
            Console.WriteLine($"Color: {myBird.Color}");
            Console.WriteLine($"Number of Legs: {myBird.NumberOfLegs}");
            Console.WriteLine($"Wing Span: {myBird.WingSpan} cm");
            Console.WriteLine($"Can Fly: {myBird.CanFly}");
            Console.WriteLine($"Beak Length: {myBird.BeakLength} cm");
            Console.WriteLine($"Favorite Food: {myBird.FavoriteFood}");

            Reptile myReptile = new Reptile();
            myReptile.Name = "Lizard";
            myReptile.Age = 3;
            myReptile.Color = "Brown";
            myReptile.NumberOfLegs = 4;
            myReptile.HasScales = true;
            myReptile.IsColdBlooded = true;
            myReptile.Habitat = "Desert";
            myReptile.TailLength = 10;

            Console.WriteLine("\nReptile Details:");
            Console.WriteLine($"Name: {myReptile.Name}");
            Console.WriteLine($"Age: {myReptile.Age}");
            Console.WriteLine($"Color: {myReptile.Color}");
            Console.WriteLine($"Number of Legs: {myReptile.NumberOfLegs}");
            Console.WriteLine($"Has Scales: {myReptile.HasScales}");
            Console.WriteLine($"Is Cold Blooded: {myReptile.IsColdBlooded}");
            Console.WriteLine($"Habitat: {myReptile.Habitat}");
            Console.WriteLine($"Tail Length: {myReptile.TailLength} cm");
        }
    }
}
