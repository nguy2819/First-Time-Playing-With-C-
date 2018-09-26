using System;

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

            StringExample.Run();

            IntAndMathExamples.Run();

            //UserInputExample.Run();

            ArraysAndIfExample.Run();

            //CalculatorExample.Run();

            SwitchExample.Run();
            
            //WhileExample.Run();

            //GuessingGame.Run();

            //GuessingGamewithWordsandConditions.Run();

            ForLoop.Run();

            Console.ReadLine(); //pause the screen so we can see the result in a longer time
        }

        
    }
}

