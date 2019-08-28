using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedListTraversal
{
    class Program
    {
        class Node
        {
            public int data;
            public Node Next;
            
        }

        static Node Push(Node head, int data)
        {
            Node newNode = new Node();
            Node temp = head;
            newNode.data = data;
            newNode.Next = head;

            if (head != null)
            {
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
            else
            {
                newNode.Next = newNode;
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
                    temp = temp.Next;
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
            Console.WriteLine("Content of circualr Linked List is : ");
            PrintList(head);

            Console.ReadKey();
        }
    }
}
