using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return head;
            }

            ListNode result = SwapPairs(head.next.next);
            ListNode output = head.next;
            head.next.next = head;
            head.next = result;
            return output;
        }
    }
}
