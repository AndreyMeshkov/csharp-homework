using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static int FindIndex(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 4, 6, 7, 3, 9 };
            int number = 7;
            Console.WriteLine(FindIndex(myArray, number));
            Console.ReadLine();
        }
    }
}
