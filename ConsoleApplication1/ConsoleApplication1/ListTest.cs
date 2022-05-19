using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ListTest
    {
        public static void listEx()
        {
            List<int> test = new List<int>();

            test.Add(1);
            test.Add(10);
            test.Add(100);

            //test.Distinct();  //去除重複

            foreach(var item in test)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("count : " + test.Count);

            Console.WriteLine("=========================== ");

            test.RemoveAt(0); //使用key

            //test.Remove(10); //刪除相同值的項目

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
        }
    }
}
