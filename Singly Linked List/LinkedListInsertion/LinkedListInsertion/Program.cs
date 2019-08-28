using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInsertion
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

        public void PrintList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        public void InsertAtStart(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void InsertAtMiddle(int data, Node previousNode)
        {
            Node newNode = new Node(data);
            newNode.next = previousNode.next;
            previousNode.next = newNode;
        }

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = new Node(data);
                return;
            }

            Node temp = head;

            while (temp.next != null)
            {
                temp = temp.next;   
            }
            temp.next = newNode;
        }

        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            lList.InsertAtEnd(6);
            lList.InsertAtStart(7);
            lList.InsertAtStart(1);
            lList.InsertAtEnd(4);
            lList.InsertAtMiddle(8, lList.head.next);

            Console.WriteLine("Linked List is : ");
            lList.PrintList();
            Console.ReadKey();
        }
    }
}
