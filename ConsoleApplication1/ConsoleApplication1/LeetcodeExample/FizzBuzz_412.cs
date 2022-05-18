using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    internal class FizzBuzz_412
    {
        //https://leetcode.com/problems/fizz-buzz/
        public IList<string> FizzBuzz(int n)
        {
            List<string> res =  new List<string>();

            for(int i = 1; i < (n+1); i++)
            {
                if(i%3==0 && i%5==0) res.Add("FizzBuzz");
                else if (i % 3 == 0) res.Add("Fizz");
                else if (i % 5 == 0) res.Add("Buzz");
                else res.Add(i.ToString());
            }
            return res;
        }

    }
}
