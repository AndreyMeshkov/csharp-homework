using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Delete(ref int[] array, int index)
        {
            int[] tmpArray = new int[array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                tmpArray[i] = array[i];
            }

            for (int i = index; i < tmpArray.Length; i++)
            {
                tmpArray[i] = array[i + 1];
            }
            array = tmpArray;
        }

        static void DeleteFirst(ref int[] array)
        {
            Delete(ref array, 0);
        }

        static void DeleteLast(ref int[] array)
        {
            Delete(ref array, array.Length - 1);
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            Delete(ref myArray, 2);
            DeleteFirst(ref myArray);
            DeleteLast(ref myArray);
        }
    }
}
