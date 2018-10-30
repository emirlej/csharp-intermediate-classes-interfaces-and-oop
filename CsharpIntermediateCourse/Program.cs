using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediateCourse
{

    class Program
    {
        
        static void Main(string[] args)
        {
            var customer = new Customer(1, "John");             
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


            // Best way to initialize classes
            var customer2 = new Customer
            {
                Id = 1,
                Name = "Joe Foo"
            };




        }
    }
}
