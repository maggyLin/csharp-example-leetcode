using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ConvertTypeTest
    {

        public static void strToInt()
        {
            string first = "5";
            string second = "7";
            int sum = int.Parse(first) + int.Parse(second);
            Console.WriteLine(sum);
        }

        public static void convertTest()
        {
            string value1 = "5";
            string value2 = "7";
            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(result);

            // Convert 類別最適合用來將小數數位轉換成整數 (int)，因為它會以您預期的方式進位
            int value3 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(value3);
        }

        /*
         * TryParse() : 此方法會嘗試將字串剖析為指定的資料類型，
         * 如果成功，此方法會將轉換後的值儲存在 out 參數中，
         * 它會傳回布林值，指出動作是否成功或失敗，
         */
        public static void TryParseTest()
        {
            string value = "102";
            //string value = "abc";
            int result = 0;
            if (int.TryParse(value, out result))
            {
                Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }
        }

    }
}
