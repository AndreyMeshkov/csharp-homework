using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Resize<T>(ref T[] array, int newSize)
        {
            T[] tmpArray = new T[newSize];
            int length = Math.Min(newSize, array.Length);
            for (int i = 0; i < length; i++)
            {
                tmpArray[i] = array[i];
            }
            array = tmpArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            Resize(ref myArray, 3);
        }
    }
}
