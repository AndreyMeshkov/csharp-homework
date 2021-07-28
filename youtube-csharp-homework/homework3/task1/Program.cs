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
            Console.WriteLine("Enter the first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation (+ - / *): ");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter the second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            if(operation == "+")
            {
                Console.WriteLine(firstNum + " " + operation +" "+ secondNum + " = " + (firstNum + secondNum));
            }
            else if(operation == "-"){
                Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + (firstNum - secondNum));
            }
            else if (operation == "*")
            {
                Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + (firstNum * secondNum));
            }
            else if (operation == "/")
            {
                if (secondNum == 0)
                {
                    Console.WriteLine("Division by zero");
                }
                else
                {
                    Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + (firstNum / secondNum));
                }
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }
            Console.ReadLine();
        }
    }
}
