using System;

namespace GetNthNodeFromEnd
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
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public int GetNthNodeFromEndOfLinkedList(int n)
        {
            int result = int.MinValue;

            int count = 0;
            Node mainNode = head;
            Node referenceNode = head;

            if (head != null)
            {
                while (count < n)
                {
                    if (referenceNode == null)
                    {
                        Console.WriteLine(n + " is greater then number of nodes in the Linked List.");
                        return -1;
                    }
                    referenceNode = referenceNode.next;
                    count++;
                }
                while (referenceNode != null)
                {
                    mainNode = mainNode.next;
                    referenceNode = referenceNode.next;
                }

                result = mainNode.data;
            }

            return result;
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

            Console.WriteLine("Linked List is :");
            lList.PrintLinkedList();

            Console.WriteLine("\nNth nnode from the end of the Linked List is : {0}", lList.GetNthNodeFromEndOfLinkedList(6));

            Console.ReadKey();
        }
    }
}
