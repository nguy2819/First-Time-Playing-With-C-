using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienFirstFrameworkProject
{
    class StringExample
    {
        public static void Run()
        {
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
        }
    }
}
