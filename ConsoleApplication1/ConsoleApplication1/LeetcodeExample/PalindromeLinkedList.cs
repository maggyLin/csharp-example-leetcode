using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class PalindromeLinkedList
    {
        //建立 正 與 反 字串 , 比對 2 字串有沒有相同
        // Time Limit Exceeded...
        public bool IsPalindromeEx1(ListNode head)
        {
            string front = "";
            string back = "";

            while(head != null)
            {
                front = front + head.val;
                back = head.val + back;
                head = head.next;
            }

            return front == back;
        }

        //參考 : https://skyyen999.gitbooks.io/-leetcode-with-javascript/content/questions/234md.html
        //找出中點,反轉後面list,比對前後list

        public bool IsPalindromeEx2(ListNode head)
        {
            ListNode midPoint = FindMiddle(head);
            ListNode rNode = ReverseList(midPoint); // 從中點反轉

            while (rNode != null)
            {
                if (head.val != rNode.val)
                {
                    return false;
                }
                head = head.next;
                rNode = rNode.next;
            }
            return true;

        }

        // 使用快慢指針找出中點
        public ListNode FindMiddle(ListNode node)
        {
            ListNode fast = node;
            ListNode slow = node;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

        //反轉
        public ListNode ReverseList(ListNode node)
        {
            if (node == null || node.next == null) return node;
            ListNode prev = null;
            ListNode cur = node;
            ListNode temp = cur;
            while (cur != null)
            {
                temp = cur;
                cur = cur.next;
                temp.next = prev;
                prev = temp;
            }
            return prev;
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
