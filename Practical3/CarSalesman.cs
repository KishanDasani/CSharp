using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    //creating the class CarSalesman which inherits the base class Salesman
    class CarSalesman : Salesman
    {
        //creating the constructor for CarSalesman class which passes the values of parameters to base class constructor
        public CarSalesman(String firstName, String lastName) : base(firstName, lastName)
        { 
        }

        //overriding the sell() method of base class
        public override void sell()
        {
            Console.WriteLine("Hello! My name is " + firstName + " " + lastName +". I recommend you to buy this car.");
            Console.ReadKey();
        }
    }
}
