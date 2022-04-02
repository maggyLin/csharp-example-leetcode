using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayResizeTest
    {

        public static void ResizeTest()
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("");

            Array.Resize(ref pallets, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
        }

        public static void ClearTest()
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };
            //Array.Clear(pallets, 0, 2);
            Array.Resize(ref pallets, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

        }

        public static void CharReverseTest()
        {
            string value = "abc123";
            //轉 char array
            char[] valueArray = value.ToCharArray();
            //反轉
            Array.Reverse(valueArray);

            //轉string
            //string result = new string(valueArray);
            //轉string帶特殊符號處理
            string result = String.Join(",", valueArray);

            //string 轉 array
            //string[] items = result.Split(',');
            //foreach (string item in items)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(result);

        }

        /*
         * 將 The quick brown fox jumps over the lazy dog
         * 產出為 ehT kciuq nworb xof spmuj revo eht yzal god
         * 處理 : 轉array(items)後針對每個字串在轉array(valAry)然後反轉,
         * 反轉後轉回string存回array(items),將array(items)轉回string(result)
         */
        public static void ReverseSplitTest()
        {
            string pangram = "The quick brown fox jumps over the lazy dog";
            string[] items = pangram.Split(' ');
            for (int i = 0; i < items.Length; i++)
            {
                char[] valAry = items[i].ToCharArray();
                Array.Reverse(valAry);
                string val = new string(valAry);
                items[i] = val;
            }
            string result = String.Join(" ", items);
            Console.WriteLine(result);

        }


    }
}
