using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MathOperatorTest
    {

        public static void QuotientTest() {
            int first = 7;
            int second = 5;

            // 不轉型直接除,會得到 int = 1
            //decimal quotien = first / second;

            decimal quotient = (decimal)first / (decimal)second;
            Console.WriteLine(quotient);
        }

        public static void RandomTest()
        {
            // If you run the code multiple times, numbers from 1 to 6 are displayed in the console output.
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);


            //Random rnd = new Random();
            //for (uint ctr = 1; ctr <= 10; ctr++)
            //Console.WriteLine($"{rnd.Next(),15:N0}");
        }



    }
}
