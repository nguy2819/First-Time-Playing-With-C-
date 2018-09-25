using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienFirstFrameworkProject
{
    class ArraysAndIfExample
    {
        public static void Run()
        {
            //Arrays
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Kelly";

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]);

            SayHi("Tien"); //Methods - Hello Tien

            Console.WriteLine(Cube(5)); //Return Statement - 125 

            int cubedNumber = Cube(5);
            Console.WriteLine(cubedNumber); //Return Statement -125





            //If Statement
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            else
            {
                Console.WriteLine("You are either not male and not tall");
            }

            if (isMale || isTall)
            {
                Console.WriteLine("You are a male or you are a tall person, we are just a if - or guessing statement");
            }
            else
            {
                Console.WriteLine("You are either not a male or a tall person");
            }



            //More If Statement
            Console.WriteLine(GetMax(20, 10, 4));
        }

        //Methods
        static void SayHi(string name)
        {
            Console.WriteLine("Hello User");
            Console.WriteLine("Hello " + name);
        }

        //Return Statement
        static int Cube(int num) //return an integer - we called it Cube for this Method - we also specify the parameter inside () => take 1 parameter and it is integer - and we called it num
        {
            int result = num * num * num;
            return result;
        }

        //More If Statement
        static int GetMax(int num1, int num2, int num3)
        {
            int result1;
            if (num1 >= num2 && num1 >= num3)
            {
                result1 = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result1 = num2;
            }
            else
            {
                result1 = num3;
            }
            return result1;
        }
    }
}
