using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class PlusOne
    {
        public static int[] Test(int[] digits)
        {

            for(int i=(digits.Length - 1); i >= 0; i--)
            {
                if(digits[i] + 1 == 10)
                {
                    digits[i] = 0;

                    // EX:[9,9,9] 要新增array長度,最前面為1
                    if (i == 0)
                    {
                        Array.Resize(ref digits, (digits.Length + 1));
                        digits[0] = 1;
                        digits[digits.Length - 1] = 0;
                    }
                }
                else
                {
                    digits[i] = digits[i] + 1;
                    break;
                }

            }

            return digits;
        }


    }
}
