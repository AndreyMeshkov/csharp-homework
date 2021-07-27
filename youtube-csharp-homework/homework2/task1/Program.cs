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
            int num;
            Console.WriteLine("Enter the number: ");
            num = int.Parse(Console.ReadLine());
            
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is even  number");
            }
            else
            {
                Console.WriteLine(num + " is odd  number");
            }
            Console.ReadLine();
        }
    }
}
