using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienFirstFrameworkProject
{
    class ForLoop
    {
        public static void Run()
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
        }
    }
}
