using System;

namespace CheckLoopInLinkedList
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

        public void PrintLinkedList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public bool DetectLoop()
        {
            Node slow = head;
            Node fast = head;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    //Console.WriteLine("Loop Found in the Linked List.");
                    return true;
                }
            }
            return false;
        }

        public int LengthOfTheLinkedList()
        {
            Node slow = head;
            Node fast = head;
            int length = 1;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    Node temp = slow;
                    while (temp.next != slow)
                    {
                        length++;
                        temp = temp.next;
                    }
                    break;
                }
            }
            return length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList lList = new LinkedList();
            lList.Push(20);
            lList.Push(4);
            lList.Push(15);
            lList.Push(10);
            lList.PrintLinkedList();

            lList.head.next.next.next.next = lList.head;

            if (lList.DetectLoop())
            {
                Console.WriteLine("Loop found in the Linked List. Length of the Loop is : {0}", lList.LengthOfTheLinkedList());
            }
            else
            {
                Console.WriteLine("No loop found in the Linked List.");
            }

            Console.ReadKey();
        }
    }
}
