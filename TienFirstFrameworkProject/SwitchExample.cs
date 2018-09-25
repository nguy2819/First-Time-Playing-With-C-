using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienFirstFrameworkProject
{
    class SwitchExample
    {
        public static void Run()
        {
            //Switch Statement in C#
            Console.WriteLine(GetDay(0)); //Sunday

        }

        //Switch Statement New Method
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0: //in the case, dayNum is 0 => dayName will be Sunday
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default: //in case people applies a dayNum is 100
                    dayName = "Invalid Day Number";
                    break;
            }
            return dayName;
        }
    }
}
