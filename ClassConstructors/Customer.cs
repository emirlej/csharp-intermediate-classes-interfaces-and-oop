using System.Collections.Generic;

namespace CsharpIntermediateCourse
{
    public class Customer
    {
        public int Id;
        public string Name;
        private List<Order> Orders { get; set; }

        public Customer()
        {
            // Important to always initialize empty list when a parameter.
            this.Orders = new List<Order>();
        }

        // ctor = contstructor shortcut
        public Customer(int id) 
            : this() // this() means calling the constructor above
        {
            this.Id = id;
        }

        // Overloading the clas
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
