using System;
using System.IO;

namespace Ch03_HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // sample catch 
            Console.WriteLine("Before parsing");
            Console.Write("What is your age? ");
            string input = Console.ReadLine();
            try
            {
                int age = int.Parse(input);
                Console.WriteLine($"You are {age} years old.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            Console.WriteLine("After parsing");

            // using finally
            string path = @"D:\Source\Testing\Chapter03"; 
            FileStream file = null;
            StreamWriter writer = null;
            try
            {
                if (Directory.Exists(path))
            {
                file = File.OpenWrite(Path.Combine(path, "file.txt"));
                writer = new StreamWriter(file);
                writer.WriteLine("Hello, C#!");
            }
            else
            {
                Console.WriteLine($"{path} does not exist!");
            }
            }
            catch (Exception ex)
            {
                // if the path doesn't exist the exception will be caught
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            finally
            {
                if (writer != null)
                {
                    writer.Dispose();
                    Console.WriteLine("The writer's unmanaged resources have been disposed.");
                }
                if (file != null)
                {
                    file.Dispose();
                    Console.WriteLine("The file's unmanaged resources have been disposed.");
                }
            }


        }
    }
}
