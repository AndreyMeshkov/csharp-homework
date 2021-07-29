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
            int[] myArray = { 15, 21, 43, 5, 16, 7, 2, 24231, 532, 12 };
            int sumOfEvenNumbers = 0;
            int minValue = myArray[0];

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
                if(myArray[i] % 2 == 0)
                {
                    sumOfEvenNumbers += myArray[i];
                }
                if(minValue > myArray[i])
                {
                    minValue = myArray[i];
                }
            }
            Console.WriteLine($"Sum of even numbers = {sumOfEvenNumbers}");
            Console.WriteLine($"Minimum numbers of array is {minValue}");
            Console.ReadLine();
        }
    }
}
