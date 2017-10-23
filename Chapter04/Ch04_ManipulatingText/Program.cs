using System;

namespace Ch04_ManipulatingText
{
    class Program
    {
        static void Main(string[] args)
        {
            // getting string length 
            string city = "London";
            Console.WriteLine($"{city} is {city.Length} characters long.");

            // splitting string
            string cities = "Paris,Berlin,Madrid,New York";
            string[] citiesArray = cities.Split(',');
            foreach (string item in citiesArray)
            {
                Console.WriteLine(item);
            }

            // joining
            string recombined = string.Join(" => ", citiesArray);
            Console.WriteLine(recombined);

            // using substring
            string fullname = "Alan Jones";
            int indexOfTheSpace = fullname.IndexOf(' ');
            string firstname = fullname.Substring(0, indexOfTheSpace);
            string lastname = fullname.Substring(indexOfTheSpace + 1);
            Console.WriteLine($"{lastname}, {firstname}");

            // checking for string inside string
            string company = "Microsoft";
            bool startsWithM = company.StartsWith("M");
            bool containsN = company.Contains("N");
            Console.WriteLine($"Starts with M: {startsWithM}, contains an N: {containsN}");
        }
    }
}
