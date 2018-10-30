using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public string UserName { get; set; }
            public DateTime Birthdate { get; private set; }


            // Since we set private setter, need to add birthdate via the initializer
            public Person(DateTime birthdate)
            {
                this.Birthdate = birthdate;
            }

            public int Age
            {
                get
                {
                    TimeSpan timeSpan = DateTime.Today - Birthdate;
                    int years = timeSpan.Days / 365;

                    return years;
                }
            }


        }

        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1988, 6, 5));
            Console.WriteLine("Age is {0}", person.Age);
        }
    }
}
