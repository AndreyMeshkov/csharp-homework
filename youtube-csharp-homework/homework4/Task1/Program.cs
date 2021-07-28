using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;
            while (isContinue)
            {
                Console.Clear();
                int start, end;
                try
                {
                    Console.WriteLine("Enter the starting range: ");
                    start = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the finishing range: ");
                    end = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number");
                    Console.ReadLine();
                    continue;
                }
                int i = start;
                uint count_odd = 0;
                uint count_even = 0;
                while(i <= end)
                {
                    if(i % 2 == 0)
                    {
                        count_even++;
                    }
                    else
                    {
                        count_odd++;
                    }
                    i++;
                }
                Console.WriteLine($"In the range from {start} to {end}, {count_even} numbers are even and {count_odd} are odd");
                Console.ReadLine();
                Console.WriteLine("Do you want count again? Yes or No: ");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "no")
                {
                    isContinue = false;
                }
            }

        }
    }
}
