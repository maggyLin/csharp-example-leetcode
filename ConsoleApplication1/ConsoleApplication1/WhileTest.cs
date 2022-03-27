using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class WhileTest
    {

        public static void DoWhileTest()
        {
            Random random = new Random();
            int current = 0;

            do
            {
                current = random.Next(5, 9);
                Console.WriteLine(current);
            } while (current != 7);
        }

        public static void WhileTest01()
        {
            Random random = new Random();
            int current = random.Next(1, 11); ;

            while (current >= 3)
            {
                Console.WriteLine($"current number: {current}");
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
        }

        public static void ContinueTest()
        {
            int i = 0;
            while (i < 5)
            {
                i++;
                if (i == 2) continue;
                Console.WriteLine($"i: {i}");
            }
        }

    }
}
