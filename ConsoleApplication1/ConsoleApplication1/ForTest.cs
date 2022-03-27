using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ForTest
    {

        public static void BreakTest1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7) break;
            }
        }

        public static void AryTest()
        {
            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        public static void FizzBuzzTest()
        {
            for (int i = 1; i < 101; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine($"{i} - FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine($"{i} - Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine($"{i} - Buzz");
                else
                    Console.WriteLine($"{i}");
            }
        }


    }
}
