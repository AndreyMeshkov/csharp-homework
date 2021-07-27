using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Average = " + (firstNum + secondNum) / 2);
            Console.ReadLine();
        }
    }
}
