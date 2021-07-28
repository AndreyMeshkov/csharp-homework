using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
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
            switch (operation)
            {
                case "+":
                    Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + (firstNum + secondNum));
                    break;
                case "-":
                    Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + (firstNum - secondNum));
                    break;
                case "*":
                    Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + (firstNum * secondNum));
                    break;
                case "/":
                    if(secondNum == 0)
                    {
                        Console.WriteLine("Division by 0");
                    }
                    else
                    {
                        Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + (firstNum / secondNum));
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            Console.ReadLine();
        }
    }
}
