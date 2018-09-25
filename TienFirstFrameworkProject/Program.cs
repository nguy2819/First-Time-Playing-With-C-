using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienFirstFrameworkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("           /|");
            Console.WriteLine("          / |");
            Console.WriteLine("         /  |");
            Console.WriteLine("        /   |");
            Console.WriteLine("       /____|");
            Console.WriteLine("Hello World");

            string characterName = "Tom";
            int characterAge;
            characterAge = 20;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't look like " + characterAge);



            //string phrase = "Giraffe Academy";
            //char grade = 'A';
            //int age = 30;
            //double gpa = 3.2;
            //bool isMale = true; //boolean

            Console.WriteLine(30);




            Console.WriteLine("Nayshlok\nLearning"); // \n - make a new line
            Console.WriteLine("Nayshlok\"Learning"); // \" - make a double quote
            Console.WriteLine("Nayshlok\n\tLearning"); // \n new line and \t tab




            string phrase = "Nayshlok Learning" + " is useful worldwide";
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length); //37 characters includes spaces
            Console.WriteLine(phrase.ToUpper()); //NAYSHLOK LEARNING IS USEFUL WORLDWIDE
            Console.WriteLine(phrase.Contains("Learning")); //true
            Console.WriteLine(phrase[0]); //N
            Console.WriteLine(phrase[2]); //y
            Console.WriteLine(phrase[9]); //L
            Console.WriteLine(phrase.IndexOf("Learning")); //9 because the word "Learning" started with L in the index position number 9
            Console.WriteLine(phrase.IndexOf("N")); //0
            Console.WriteLine(phrase.IndexOf("z")); //-1 because there is no z in the whole phrase "Nayshlok Learning is useful worldwide"
            Console.WriteLine(phrase.Substring(9)); //this will get the whole strings started from the index 9 - which the result is "Learning is useful worldwide"
            Console.WriteLine(phrase.Substring(21)); //useful worldwide
            Console.WriteLine(phrase.Substring(21, 3)); //3 is how many characters we want to get -> the result is "use"



            Console.WriteLine(5+8); //13 rather than print out what we say, C# will do math for us
            Console.WriteLine(5%2); //remainder is 1
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
            Console.WriteLine(Math.Pow(3 , 2)); //9 because 3 power 2 is 9
            Console.WriteLine(Math.Pow(3.66, 2)); //13.3956
            Console.WriteLine(Math.Sqrt(36)); //6
            Console.WriteLine(Math.Max(4, 90)); //It will give you the biggest number is 90
            Console.WriteLine(Math.Min(4, 90)); //4
            Console.WriteLine(Math.Round(3.4)); //iterator will round the number for you - which is 3
            Console.WriteLine(Math.Round(3.5)); //4




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



            //Arrays
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};
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
            } else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            } else if (!isMale && isTall)
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
            }else if(op == "-")
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

            Console.ReadLine(); //pause the screen so we can see the result in a longer time
        }

        //More If Statement
        static int GetMax(int num1, int num2, int num3)
        {
            int result1;
            if (num1 >= num2 && num1 >= num3)
            {
                result1 = num1;
            }else if (num2 >= num1 && num2 >= num3)
            {
                result1 = num2;
            }
            else
            {
                result1 = num3;
            }
            return result1;
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
    }
}

