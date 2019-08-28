using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateLinkedList
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

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void RotateLinkedList()
        {
            Node temp = head;
            Node previous = null;

            while (temp.next != null)
            {
                previous = temp;
                temp = temp.next;
            }
            previous.next = null;
            temp.next = head;
            head = temp;
        }

        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            lList.Push(5);
            lList.Push(4);
            lList.Push(3);
            lList.Push(2);
            lList.Push(1);

            Console.WriteLine("Origional Linked List is : ");
            lList.PrintList();

            int numberOfTimeToRotate = 2;

            for (int i = 0; i < numberOfTimeToRotate; i++)
            {
                lList.RotateLinkedList();
            }

            Console.WriteLine("\nModified Linked List is : ");
            lList.PrintList();

            Console.ReadKey();
        }
    }
}
