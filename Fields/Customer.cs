using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    class Customer
    {
        public int Id;
        public string Name;
        // Readonly means you can assign it only once
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // This is a bug to exemplify readonly field
            this.Orders = new List<Order>();
        }
    }
}
