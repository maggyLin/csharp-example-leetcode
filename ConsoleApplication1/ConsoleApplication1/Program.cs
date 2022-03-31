using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities;

using ConsoleApplication1.LeetcodeExample;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //string input = Console.ReadLine();
            //Console.WriteLine(input);
            //IFTest test = new IFTest();
            //test.TestIf(int.Parse(input));

            //StringTest.test2();

            //MathOperatorTest.QuotientTest();

            //ArrayForTest.foreachTest();

            // 不同 namespace
            //string value = "Microsoft Learn";
            //string reversedValue = Utility.Reverse(value);
            //Console.WriteLine($"Secret message: {reversedValue}");

            //SwitchCaseTest.test(500);

            //ForTest.FizzBuzzTest();

            //WhileTest.ContinueTest();

            // array 是 參考型別
            //ArrayForTest.ArrayTest();

            //IntegralRange.FloatingRangeTest();

            //ConvertTypeTest.convertTest();

            //ArrayResizeTest.ResizeTest();
            //ArrayResizeTest.ReverseSplitTest();

            //StringFormatTest.currencyFormatTest();
            //StringFormatTest.NumbersFormatTest();
            //StringFormatTest.FormatTest2();
            //StringFormatTest.AlignTest();

            //QueueAndStack.queueEx();
            //QueueAndStack.StackEx();

            //MergeTwoSortedLists.SortListTest();

            int[] nums = { 1, 3, 4, 6, 8, 9, 10, 13, 15 };

            Console.WriteLine(SearchInsertPosition.searchInsert(nums, 5));

            Console.ReadKey();
        }
    }
}

namespace Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}
