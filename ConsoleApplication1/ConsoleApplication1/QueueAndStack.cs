using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //queue 先進先出 , stack 後進先出

    class QueueAndStack
    {
        public static void queueEx()
        {
            Queue<string> myque = new Queue<string>();

            myque.Enqueue("one");
            myque.Enqueue("two");
            myque.Enqueue("three");
            myque.Enqueue("four");

            foreach (string item in myque)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine(" 查看第一個資料 Peek() :" + myque.Peek());
            Console.WriteLine(" ElementAt 特定位置值 :" + myque.ElementAt(1));

            Console.WriteLine("---------------------------");
            Console.WriteLine(" 提出第一個資料 Dequeue() " + myque.Dequeue());
            Console.WriteLine(" 目前的第一個 " + myque.Peek());

        }


        public static void StackEx()
        {
            Stack<string> myStack = new Stack<string>();

            myStack.Push("one");
            myStack.Push("two");
            myStack.Push("three");
            myStack.Push("four");

            foreach (string item in myStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine(" 查看第一個資料 Peek() :" + myStack.Peek());
            Console.WriteLine(" ElementAt 特定位置值 :" + myStack.ElementAt(1));

            Console.WriteLine("---------------------------");
            Console.WriteLine(" 提出第一個資料 Pop() " + myStack.Pop());
            Console.WriteLine(" 目前的第一個 " + myStack.Peek());

        }



    }
}
