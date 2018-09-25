using System;

namespace TienFirstFrameworkProject
{
    class IntAndMathExamples
    {
        public static void Run()
        {
            Console.WriteLine(5 + 8); //13 rather than print out what we say, C# will do math for us
            Console.WriteLine(5 % 2); //remainder is 1
            Console.WriteLine(4 + 2 * 3); //10
            Console.WriteLine((4 + 2) * 3); //18
            Console.WriteLine(5.0 + 8.1); //13.1 - the same as Console.WriteLine(5 + 8.1);
            Console.WriteLine(5 / 2); //2
            Console.WriteLine(5 / 2.0); //2.5

            int num = 6;
            Console.WriteLine(num); //6
            num++;
            Console.WriteLine(num); //7
            //something will be fun to know: --num and num--

            Console.WriteLine(Math.Abs(-40)); //40
            Console.WriteLine(Math.Pow(3, 2)); //9 because 3 power 2 is 9
            Console.WriteLine(Math.Pow(3.66, 2)); //13.3956
            Console.WriteLine(Math.Sqrt(36)); //6
            Console.WriteLine(Math.Max(4, 90)); //It will give you the biggest number is 90
            Console.WriteLine(Math.Min(4, 90)); //4
            Console.WriteLine(Math.Round(3.4)); //iterator will round the number for you - which is 3
            Console.WriteLine(Math.Round(3.5)); //4
        }
    }
}
