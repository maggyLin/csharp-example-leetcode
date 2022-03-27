using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class ValidParentheses
    {

        public static bool IsValid2(string s)
        {
            if (s.Length % 2 != 0) return false;

            char[] strAry = s.ToCharArray();

            Stack<char> tmpBracket = new Stack<char>();

            for (int i = 0; i < strAry.Length; i++)
            {
                switch (strAry[i])
                {
                    case '(':
                    case '[':
                    case '{':
                        tmpBracket.Push(strAry[i]);
                        break;
                    case ')':
                    case ']':
                    case '}':
                        if (tmpBracket.Count() == 0) return false;
                        char lastBra = tmpBracket.Pop();
                        char correctBra ='(';
                        if (strAry[i] == ']') correctBra = '[';
                        if (strAry[i] == '}') correctBra = '{';
                        if(lastBra != correctBra) return false;
                        break;
                    default:
                        return false;
                }
            }
            if (tmpBracket.Count() != 0) return false;
            return true;
        }

        //ERR : "{[]}" , "{[]()}()" => 可能會有這樣狀況 , 不能一組一組確認
        public static bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;

            char[] strAry = s.ToCharArray();

            for (int i = 0; i < strAry.Length; i++)
            {
                if ((i + 1) % 2 == 0) //index偶數(一組一起確認)
                {
                    switch (strAry[i])
                    {
                        case ')':
                            if (strAry[i-1] != '(') return false;
                            break;
                        case '}':
                            if (strAry[i - 1] != '{') return false;
                            break;
                        case ']':
                            if (strAry[i - 1] != '[') return false;
                            break;
                        default:
                            return false;
                    }
                }
            }

            return true;
        }
        
    }
}
