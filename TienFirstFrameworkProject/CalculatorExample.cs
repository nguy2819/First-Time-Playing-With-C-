using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienFirstFrameworkProject
{
    class CalculatorExample
    {
        public static void Run()
        {
            //Build a Better Calculator
            Console.Write("Enter a number: ");
            double num5 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num6 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num5 + num6);
            }
            else if (op == "-")
            {
                Console.WriteLine(num5 - num6);
            }
            else if (op == "/")
            {
                Console.WriteLine(num5 / num6);
            }
            else if (op == "*")
            {
                Console.WriteLine(num5 * num6);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }
    }
}
