using System;
using static System.Console;

namespace Ch02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;                   // storing a double in an object
            object name = "Amir";                   // storing a string in an object
            //int length1 = name.Length;              // gives compile error!
            int length2 = ((string)name).Length;    // cast to access members    

            /*
            int population = 66_000_000; // 66 million in UK
            double weight = 1.88; // in kilograms
            decimal price = 4.99M; // in pounds sterling
            string fruit = "Apples"; // strings use double-quotes
            char letter = 'Z'; // chars use single-quotes
            bool happy = true; // Booleans have value of true or false                
            */

            var population = 66_000_000; // 66 million in UK
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            var letter = 'Z'; // chars use single-quotes
            var happy = true; // Booleans have value of true or false

            WriteLine($"{default(int)}"); // 0
            WriteLine($"{default(bool)}"); // False
            WriteLine($"{default(DateTime)}"); // 1/01/0001 00:00:00

            ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor),args[0], true);
            BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor),args[1], true);
            WindowWidth = int.Parse(args[2]);
            WindowHeight = int.Parse(args[3]);

            WriteLine($"There are {args.Length} arguments.");
            foreach (var arg in args)
            {
                WriteLine(arg);
            }
        }
    }
}
