using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_Assignment
{
    class ParentClass
    {
        private string[] range = new string[5];
        public string this[int indexrange]
        {
            get { return range[indexrange]; }
            set { range[indexrange] = value; }
        }

    }

    class Program
    {
        static void Main(String[] args)
        {
            ParentClass obj = new ParentClass();
            obj[0] = "Hi";
            obj[1] = "Hello";
            obj[2] = "How are you";
            obj[3] = "FO";
            obj[4] = "GTH";

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", obj[0],obj[1],obj[2],obj[3],obj[4]);
            Console.Read();
        }
    }
}