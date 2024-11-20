using System;
using Tyuiu.mohamed.Sprint2.Task0.V28.lib;
namespace Tyuiu.mohamed.Sprint2.Task0.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                // Create an instance of DataService
                DataService dataService = new DataService();

                // Input values for x and y
                Console.WriteLine("Enter value for x:");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for y:");
                int y = Convert.ToInt32(Console.ReadLine());

                // Get comparison results
                bool[] results = dataService.GetCompareOperations(x, y);

                // Display the results
                Console.WriteLine("Comparison Results:");
                Console.WriteLine($"x == y: {results[0]}");
                Console.WriteLine($"x != y: {results[1]}");
                Console.WriteLine($"x < y:  {results[2]}");
                Console.WriteLine($"x > y:  {results[3]}");
                Console.WriteLine($"x <= y: {results[4]}");
                Console.WriteLine($"x >= y: {results[5]}");

                // Wait for user input before closing
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}