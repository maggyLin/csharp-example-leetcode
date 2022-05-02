using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class PascalTriangle_118
    {

        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>();

            //default 第一筆 [1]
            IList<int> def = new List<int>();
            def.Add(1);
            res.Add(def);

            for (int i=1; i < numRows; i++)
            {
                IList<int> resTmp = new List<int>();
                for (int j = 0; j < (i+1); j++)
                {
                    //最前面 跟 最後面 一定為 1
                    if (j == 0 || j == i ) resTmp.Add(1);
                    //中間項目 為 上一項(i-1) 的 (j-1) + (j+1)
                    else resTmp.Add(res[(i - 1)][j-1] + res[(i - 1)][j]);
                }

                res.Add(resTmp);
            }

            return res;

        }


    }
}
