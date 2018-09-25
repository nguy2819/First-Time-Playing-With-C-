using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienFirstFrameworkProject
{
    class UserInputExample
    {
        public static void Run()
        {
            //Getting User Input
            Console.Write("Enter your name: ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Hello " + name);


            //Building a Calculator
            int num2 = Convert.ToInt32("45");
            Console.WriteLine(num2 + 5); //50
            Console.WriteLine("43" + "56"); //4356

            Console.Write("Enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num3 + num4);


            //Building a Mad Libs Game

            string color, pluralNoun, celebrity;
            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{pluralNoun} are blue");
            Console.WriteLine($"I Love {celebrity}");

        }
    }
}
