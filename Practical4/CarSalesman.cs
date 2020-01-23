using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    class CarSalesman : ISalesman
    {
        private String firstName;
        private String lastName;

        public CarSalesman(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void sell()
        {
            Console.WriteLine("Hello! My name is " + firstName + " " + lastName + ". I recommend you to buy this car.");
            Console.ReadKey();
        }
    }
}
