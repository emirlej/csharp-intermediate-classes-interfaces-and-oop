using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {

        public class Person
        {
            // private field start with underscore
            private DateTime _birthdate;

            // The two methods below are just examples
            public void SetBirthDate(DateTime birthdate)
            {
                this._birthdate = birthdate;
            }

            public DateTime GetBirthDate()
            {
                return this._birthdate;
            }
        }

        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthDate());

            // Why use private when we needed to create two functions
            // in order to get/set the birthdate?
            // Answer: This is a stupid example, but some things are implementation
            // details, and should be hidden from the outside world. 
            
        }
    }
}
