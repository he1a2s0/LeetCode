using System;
using System.Collections.Generic;

namespace _002.Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var l1 = new ListNode(2);
            var l2 = new ListNode(5);

            var result = solution.AddTwoNumbers(l1, l2);

            Console.WriteLine("{0} + {1} = {2}", PrintListNode(l1), PrintListNode(l2), PrintListNode(result));

            l1.next = new ListNode(4) { next = new ListNode(3) };
            l2.next = new ListNode(6) { next = new ListNode(4) };
            result = solution.AddTwoNumbers(l1, l2);

            Console.WriteLine("{0} + {1} = {2}", PrintListNode(l1), PrintListNode(l2), PrintListNode(result));


            l1 = new ListNode(5);
            l2 = new ListNode(5);
            result = solution.AddTwoNumbers(l1, l2);
            Console.WriteLine("{0} + {1} = {2}", PrintListNode(l1), PrintListNode(l2), PrintListNode(result));
        }

        static string PrintListNode(ListNode listNode)
        {
            var valList = new List<int>();
            var currentNode = listNode;
            while (currentNode != null)
            {
                valList.Add(currentNode.val);

                currentNode = currentNode.next;
            }

            return string.Join("->", valList);
        }
    }
}
