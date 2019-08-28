using System;

namespace RemoveLoopInLinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    class LinkedList
    {
        Node head;

        public LinkedList()
        {
            head = null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void PrintList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        public void DetectAndLoopInLinkedList()
        {
            Node slow = head;
            Node fast = head;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    Console.WriteLine("\nLoop Found");
                    break;
                }
            }

            if (slow == fast)
            {
                slow = head;
                while (slow.next != fast.next)
                {
                    slow = slow.next;
                    fast = fast.next;
                }
                fast.next = null; // Removing the loop.
                Console.WriteLine("Loop Removed.");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList lList = new LinkedList();

            lList.Push(5);
            lList.head = new Node(10);
            lList.Push(4);
            lList.Push(15);
            lList.Push(20);
            lList.Push(50);

            Console.WriteLine("Linked List is : ");
            lList.PrintList();


            lList.head.next.next.next.next.next = lList.head.next.next;

            lList.DetectAndLoopInLinkedList();

            lList.PrintList();


            Console.ReadKey();
        }
    }
}
