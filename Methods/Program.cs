using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{

    
        
    class Program
    {
        static void Main(string[] args)
        {
            UseCalculator();

            UsePoints();

            // Example usage of int.TryParse
            bool result = int.TryParse("abc", out int number);
            Console.WriteLine($"Result: {result}, number: {number}");

        }

        static void UseCalculator()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 29));
        }

        static void UsePoints()
        {
            try
            {
                // Testing out the class
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine($"Point is at {point.X}, {point.Y}");

                // Second overload method
                point.Move(100, 200);
                Console.WriteLine($"Point is at {point.X}, {point.Y}");
            }
            catch (Exception)
            {

                Console.WriteLine("Error occured. Check your code");
            }
        }
    }
}
