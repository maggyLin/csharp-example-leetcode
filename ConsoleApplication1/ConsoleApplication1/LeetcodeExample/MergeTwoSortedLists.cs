using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class MergeTwoSortedLists
    {

        public static void SortListTest()
        {
            List<ListNode> list1 = new List<ListNode>();
            List<ListNode> list2 = new List<ListNode>();

            ListNode data13 = new ListNode(5, null);
            ListNode data12 = new ListNode(3, data13);
            ListNode data11 = new ListNode(1, data12);


            list1.Add(data11);
            list1.Add(data12);
            list1.Add(data12);

            ListNode data23 = new ListNode(6, null);
            ListNode data22 = new ListNode(4, data23);
            ListNode data21 = new ListNode(2, data22);

            list2.Add(data21);
            list2.Add(data22);
            list2.Add(data23);

            ListNode sortList = MergeTwoLists(data11, data21);


            //Console.WriteLine(sortList.val);
            //Console.WriteLine(sortList.next.val);
            Console.WriteLine(sortList.next.next.val);
        

        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            if (list1.val < list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }

    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
