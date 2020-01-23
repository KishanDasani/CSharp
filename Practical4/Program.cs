using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            RetailSalesman RS = new RetailSalesman("Kishan", "Dasani");

            RS.sell();

            CarSalesman CS = new CarSalesman("Jay", "Dasani");

            CS.sell();

        }
    }
}
