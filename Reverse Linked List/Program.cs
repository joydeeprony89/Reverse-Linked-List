using System;

namespace Reverse_Linked_List
{
    class Program
    {
        public class ListNode
        {
            public int Value { get; set; }
            public ListNode next { get; set; }
            public ListNode(int val = 0, ListNode next = null)
            {
                Value = val; this.next = next;
            }
        }
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            var result = Reverse(head);
            while (result != null)
            {
                Console.WriteLine(result.Value);
                result = result.next;
            }
        }

        static ListNode Reverse(ListNode head)
        {
            if (head == null) return head;
            ListNode current = head;
            ListNode prev = null;
            while(current != null)
            {
                ListNode next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }
    }
}
