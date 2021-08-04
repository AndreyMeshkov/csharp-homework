using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void PrintArray(int[] array, int i = 0)
        {
            if (i == array.Length)
            {
                return;
            }
            Console.WriteLine(array[i]);
            i++;
            PrintArray(array, i);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 3, 5, 67, 8, 95, 23, 65, 89 };
            PrintArray(myArray);
            Console.ReadLine();
        }
    }
}
