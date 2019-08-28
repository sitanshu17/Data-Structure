using System;

namespace ReverseLinkedList
{
    class Node
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

        public void ReverseLinkedList()
        {
            Node previous = null;
            Node current = head;
            Node next = null;

            while (current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            head = previous;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList lList = new LinkedList();
            lList.Push(5);
            lList.Push(4);
            lList.Push(3);
            lList.Push(2);
            lList.Push(1);

            lList.PrintList();

            lList.ReverseLinkedList();

            Console.WriteLine("\nReversed Linked List is : ");

            lList.PrintList();

            Console.WriteLine("\nOrigional Linked List is : ");
            lList.ReverseLinkedList();
            lList.PrintList();

            Console.ReadKey();
        }
    }
}
