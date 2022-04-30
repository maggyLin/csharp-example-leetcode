using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class ReverseLinkedList
    {
        //https://ithelp.ithome.com.tw/articles/10271920
        //將link指向反過來
        public ListNode ReverseList(ListNode head)
        {
            ListNode next = null;
            ListNode curr = head;
            ListNode pre = null;

            while (next != null)
            {
                next = curr.next;
                curr.next = pre;
                pre = curr;
                curr = next;
            }

            return pre;
        }


        /**
        * Definition for singly-linked list.
        * public class ListNode {
        *     public int val;
        *     public ListNode next;
        *     public ListNode(int val=0, ListNode next=null) {
        *         this.val = val;
        *         this.next = next;
        *     }
        * }
        */

    }
}
