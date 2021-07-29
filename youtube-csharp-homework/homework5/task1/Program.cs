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
            Console.WriteLine("Enter the width of the triangle: ");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < width; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("#", i + 1)));
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = width -1; i >= 0; i--)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("#", i + 1)));
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < width; i++)
            {
                Console.Write(string.Concat(Enumerable.Repeat(" ", width - 1 - i)));
                Console.WriteLine(string.Concat(Enumerable.Repeat("#", i + 1)));
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = width -1; i >= 0; i--)
            {
                Console.Write(string.Concat(Enumerable.Repeat(" ", width - 1 - i)));
                Console.WriteLine(string.Concat(Enumerable.Repeat("#", i + 1)));
            }

            Console.ReadLine();
        }
    }
}
