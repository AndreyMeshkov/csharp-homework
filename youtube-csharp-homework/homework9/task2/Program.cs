using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Sum(int[] array, int i = 0, int sum = 0)
        {
            if (i >= array.Length)
            {
                Console.WriteLine(sum);
                return;
            }
            sum += array[i];
            i++;
            Sum(array, i, sum);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 3, 5, 7, 8, 15, 23, 35, 49 };
            Sum(myArray);
            Console.ReadLine();
        }
    }
}
