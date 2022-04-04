using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class RemoveDuplicatesfromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode res = head;
            while(head.next != null)
            {
                if (head.next.val != head.val) head = head.next;
                else head.next = head.next.next;


            }

            return res;
        }

    }


    // Definition for singly-linked list.
    //public class ListNode
    //{
    //    public int val;
    //    public ListNode next;
    //    public ListNode(int val = 0, ListNode next = null)
    //    {
    //        this.val = val;
    //        this.next = next;
    //    }
    //}

}
