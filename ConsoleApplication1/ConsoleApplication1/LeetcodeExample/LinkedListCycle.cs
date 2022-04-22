using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class LinkedListCycle
    {

        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int x) {
         *         val = x;
         *         next = null;
         *     }
         * }
         */

        // 如果會回到出現過的節點->是一個cycle
        // 快指針 fast 一次走兩步，
        // 慢指針 slow 一次走一步，
        // 所以快指針 fast 永遠會追擊著慢指針 slow，
        // 期待有 cycle 的話， fast 會追上 slow 

        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;

            ListNode slow = head;
            ListNode fast = head;

            while (slow.next != null && fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
