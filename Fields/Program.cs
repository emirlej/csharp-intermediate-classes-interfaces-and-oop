using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(id: 1);

            // Add orders
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine("Number of orders: {0}", customer.Orders.Count);

            // This will not work, check Promote method
            customer.Promote();
        }
    }
}
