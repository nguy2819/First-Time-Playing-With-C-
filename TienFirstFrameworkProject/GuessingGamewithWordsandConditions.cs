using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienFirstFrameworkProject
{
    class GuessingGamewithWordsandConditions
    {
        public static void Run()
        {
            string secretWord = "Tien";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter the secret Word: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }
        }
    }
}
