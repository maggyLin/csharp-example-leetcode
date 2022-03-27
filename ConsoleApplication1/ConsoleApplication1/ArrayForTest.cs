using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayForTest
    {

        //string[] orderIDs = new string[10];

        public static void ArrayTest()
        {
            // array 是 參考型別 , 修改tmp, names 也會被修改,記憶體位置指向相同
            string[] names = { "Alex", "Eddie", "David", "Michael" };
            string[] tmp = names;
            names[1] = "aaa";

            Console.WriteLine("names ary : ");

            foreach (var item in names)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\ntmp ary : ");

            foreach (var item in tmp)
            {
                Console.WriteLine(item.ToString());
            }

        }


        public static void foreachTest()
        {
            string[] names = { "Bob", "Conrad", "Grant" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }

        public static void foreachTest2()
        {
            string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            int countStartWithB = 0;
            foreach(string item in orderIDs)
            {
                // Contains()、StartsWith() 、 EndsWith()
                if (item.StartsWith("B"))
                {
                    Console.WriteLine(item);
                    countStartWithB++;
                }
            }

            Console.WriteLine($"total : {countStartWithB}");
        }





    }
}
