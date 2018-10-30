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

            // Testing out the class
            var point = new Point(10, 20);
            point.Move(new Point(40, 60));
            Console.WriteLine($"Point is at {point.X}, {point.Y}");

            // Second overload method
            point.Move(100, 200);
            Console.WriteLine($"Point is at {point.X}, {point.Y}");


        }
    }
}
