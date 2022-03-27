using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StringTest
    {
        public void InterpolationTest()
        {
            // $(字串插補 interpolation) : 使用{ }串接
            string greeting = "hi, ";
            string firstname = "bob";
            string message = greeting + " " + firstname + "!";
            string message2 = $"{greeting} {firstname}!";
            Console.WriteLine(message2);
        }

        public static void test2()
        {
            //@( 跳脫序列Escape Sequences):不需要反斜線直接呈現""內容  
            //$(字串插補 Interpolation) : 可使用{}串接

            Console.WriteLine("c:\\source\\repos");
            Console.WriteLine(@"c:\source\repos");

            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");
        }

        public static void test3()
        {
            //  \n:換行  \t:空格
            string greeting = "hi, ";
            string firstname = "bob";
            Console.WriteLine($"{greeting}\n\t{firstname}");
        }



    }
}
