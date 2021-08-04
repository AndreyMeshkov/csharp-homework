using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Insert(ref int[] array, int value, int index)
        {
            int[] tmpArray = new int[array.Length + 1];
            tmpArray[index] = value;
            for (int i = 0; i < index; i++)
            {
                tmpArray[i] = array[i];
            }
            for (int i = index + 1; i < tmpArray.Length; i++)
            {
                tmpArray[i] = array[i - 1];
            }
            array = tmpArray;
        }
        static void InsertFirst(ref int[] array, int value)
        {
            Insert(ref array, value, 0);
        }

        static void InsertLast(ref int[] array, int value)
        {
            Insert(ref array, value, array.Length);
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 3, 5, 7, 9 };
            Insert(ref myArray, 12, 2);
            InsertFirst(ref myArray, 10);
            InsertLast(ref myArray, 100);
        }
    }
}
