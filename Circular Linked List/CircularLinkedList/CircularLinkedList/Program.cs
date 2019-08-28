using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    class Program
    {
        class Node
        {
            public int data;
            public Node next;
        }

        static Node Push(Node head, int data)
        {
            Node newNode = new Node();
            Node temp = head;
            newNode.data = data;
            newNode.next = head;

            if (head != null)
            {
                while (temp.next != head)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            else
            {
                newNode.next = newNode;
            }

            head = newNode;
            return head;
        }

        static void PrintList(Node head)
        {
            Node temp = head;

            if (head != null)
            {
                do
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                } while (temp != head);
            }
        }

        static void Main(string[] args)
        {
            Node head = null;

            head = Push(head, 12);
            head = Push(head, 56);
            head = Push(head, 2);
            head = Push(head, 11);

            Console.WriteLine("Circualr Linked List is : ");
            PrintList(head);

            Console.ReadKey();
        }
    }
}
