using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object of retailsalesman and calling the sell method for that class
            RetailSalesman RS = new RetailSalesman("Kishan","Dasani");

            //calling the sell() method with RetailSalesman class's object
            RS.sell();

            //creating object of retailsalesman and calling the sell method for that class
            CarSalesman CS = new CarSalesman("Jay", "Dasani");

            //calling the sell() method with CarSalesman class's object
            CS.sell();
        }
    }
}
