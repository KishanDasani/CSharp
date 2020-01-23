using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    //this is the base class to be derived by other classes
    public abstract class Salesman
    {
        //declaring variables for base class
        public string firstName;
        public string lastName;

        //defining constructor to initialize the variables
        public Salesman(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //defining a base class abstract method sell() to be implemented by derived classes
        abstract public void sell();
    }
}