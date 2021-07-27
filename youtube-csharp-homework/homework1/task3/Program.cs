using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount USD");
            double usd = double.Parse(Console.ReadLine());
            double rub = 73.70;
            double byn = 2.52;
            Console.WriteLine(usd + " USD = " + rub * usd + " RUB");
            Console.WriteLine(usd + " USD = " + byn * usd + " BYN");
            Console.ReadLine();
        }
    }
}
