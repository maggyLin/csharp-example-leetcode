using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StringFormatTest
    {

        public static void FormatTest()
        {

            string first = "Hello";
            string second = "World";

            //Composite Formatting
            string result = string.Format("{0} {1}!", first, second);
            Console.WriteLine(result);

            //string interpolation
            Console.WriteLine($"{first} {second}!");

        }

        public static void currencyFormatTest()
        {
            decimal price = 123.45m;
            int discount = 50;

            //:C 貨幣格式指定子是用來將 price 與 discount 變數呈現為貨幣(會自動抓取目前地區)
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            Console.WriteLine(string.Format("{0:C}!", price));
        }

        public static void NumbersFormatTest()
        {
            decimal measurement = 123456.78912m;

            //:N 格式化數字
            Console.WriteLine($"Measurement: {measurement:N}");
            //:N4 取4位小數
            Console.WriteLine($"Measurement: {measurement:N4}");

            decimal tax = .36785m;
            //:P 表示%
            Console.WriteLine($"Tax rate: {tax:P2}");
        }

        public static void FormatTest2()
        {
            int invoiceNumber = 1201;
            decimal productMeasurement = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");
            Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
            Console.WriteLine($"     Sub Total: {subtotal:C}");
            Console.WriteLine($"           Tax: {taxPercentage:P2}");
            Console.WriteLine($"     Total Due: {total:C}");
        }

        public static void AlignTest()
        {
            string input = "Pad this";
            //左邊補空白到指定總長度
            Console.WriteLine(input.PadLeft(12));
            //使用指定符號捕到總長度
            Console.WriteLine(input.PadLeft(12, '-'));
            Console.WriteLine(input.PadRight(12, '-'));

            //string paymentId = "769";
            //string payeeName = "Mr. Stephen Ortega";
            //string paymentAmount = "$5,000.00";

            //var formattedLine = paymentId.PadRight(6);
            //formattedLine += payeeName.PadRight(24);
            //formattedLine += paymentAmount.PadLeft(10);

            //Console.WriteLine("1234567890123456789012345678901234567890");
            //Console.WriteLine(formattedLine);
        }


    }
}
