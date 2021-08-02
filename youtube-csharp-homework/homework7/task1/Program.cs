using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void PrintString()
        {
            Console.Write("Enter character: ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Enter the number of characters: ");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write(ch);
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            PrintString();
        }
    }
}
