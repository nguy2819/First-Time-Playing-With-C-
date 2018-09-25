using System;

namespace TienFirstFrameworkProject
{
    class WhileExample
    {
        public static void Run()
        {
            int index = 6;
            do //this is a do-while loop
            {
                Console.WriteLine(index); //so they still print out the index number 6 and then check while loop - break and STOP.
                index++;
            } while (index <= 5) ;

            int counter = 0;
            while (true)
            {
                counter++;
                Console.WriteLine(counter); //we increment first - so started at 1 to 11
                if (counter >= 10)
                {
                    break;
                }
            }
        }
    }
}
