using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    //https://leetcode.com/problems/add-binary/


    class AddBinary
    {
        public static string Test(string a, string b)
        {
            char[] aAry = a.ToCharArray();
            char[] bAry = b.ToCharArray();

            Array.Reverse(aAry);
            Array.Reverse(bAry);

            List<char> res = new List<char>();

            int len = aAry.Length > bAry.Length ? aAry.Length : bAry.Length;

            int carryNum = 0; //是否有進位

            for (int i = 0; i < len; i++)
            {
                // (int)aAry[i] 會轉成 ASCII 碼 ( if aAry[i]=1 => 48) ,不然要使用 減0
                // Convert.ToInt32(maxCharArr[i] - '0')
                // https://blog.cashwu.com/blog/csharp-convert-char-to-int/

                int aNum = (aAry.Length - 1 >= i) ? int.Parse(aAry[i].ToString()) : 0;
                int bNum = (bAry.Length - 1 >= i) ? int.Parse(bAry[i].ToString()) : 0;

                int sum = carryNum + aNum + bNum;

                if (sum==0)
                {
                    res.Add('0');
                    carryNum = 0;
                }
                else if (sum == 1)
                {
                    carryNum = 0;
                    res.Add('1');
                }
                else if (sum == 2)
                {
                    carryNum = 1;
                    res.Add('0');
                }
                else if (sum == 3)
                {
                    carryNum = 1;
                    res.Add('1');
                }

            }

            // 最後是否還有進位
            if(carryNum !=0 ) res.Add('1');

            res.Reverse();

            return string.Join("", res);

        }
    }
}
