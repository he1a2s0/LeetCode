using System;

namespace _002.Add_Two_Numbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null || l2 == null)
                throw new ArgumentException();

            ListNode node1 = l1, node2 = l2;
            var sum = node1.val + node2.val;
            var carry = sum >= 10;
            if (carry) sum -= 10;
            ListNode lnSum = new ListNode(sum);

            var nodeSum = lnSum;

            while (true)
            {
                node1 = node1?.next;
                node2 = node2?.next;
                if (node1 == null && node2 == null){
                  if(carry)
                    nodeSum.next = new ListNode(1);
                  return lnSum;
                }

                if (node1 == null)
                    sum = node2.val;
                else if (node2 == null)
                    sum = node1.val;
                else
                {
                    sum = node1.val + node2.val;
                }
                if (carry) sum++;
                carry = sum >= 10;
                if (carry) sum -= 10;

                nodeSum.next = new ListNode(sum);
                nodeSum = nodeSum.next;
            }
        }
    }
}
