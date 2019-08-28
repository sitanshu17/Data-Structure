using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListIntroduction
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

        public void PrintList()
        {
            Node temp = head;

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            lList.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            lList.head.next = second;
            second.next = third;

            Console.Write("Linked List is : ");
            lList.PrintList();

            Console.ReadKey();
        }
    }
}
