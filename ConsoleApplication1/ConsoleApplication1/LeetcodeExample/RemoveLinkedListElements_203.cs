using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    //https://leetcode.com/problems/remove-linked-list-elements/
    internal class RemoveLinkedListElements_203
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return null;
            head.next = RemoveElements(head.next, val);
            return head.val == val ? head.next : head;

        }



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
