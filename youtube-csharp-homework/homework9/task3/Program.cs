using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Sum(int number, int i = 0, int sum = 0)
        {
            string strNumber = number.ToString();
            if (i >= strNumber.Length)
            {
                Console.WriteLine(sum);
                return;
            }
            sum += int.Parse(strNumber[i].ToString());
            i++;
            Sum(number, i, sum);
        }
        static void Main(string[] args)
        {
            Sum(561);
            Console.ReadLine();
        }
    }
}
