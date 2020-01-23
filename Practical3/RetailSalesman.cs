using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    //creating RetailSaleman class which  inherites the Salesman class
    class RetailSalesman : Salesman
    {
        //creating constructor for RetailSalesman class which passes the values of variables to base class constructor
        public RetailSalesman(String firstName, String lastName) : base(firstName, lastName)
        {
        }

        //overriding the sell() method of base class
        public override void sell()
        {
            Console.WriteLine("Hello! My name is " + firstName + " " + lastName + ". I recommend you to buy this retail product.");
            Console.ReadKey();
        }
    }
}
