using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLLInGivenSizeGroup
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

        public Node ReverseLinkedListInGivenGroupSize(Node referenceNode, int size)
        {
            Node current = referenceNode;
            Node next = null;
            Node previous = null;
            int count = 0;

            while (count < size && current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
                count++;
            }

            if (next != null)
            {
                referenceNode.next = ReverseLinkedListInGivenGroupSize(next, size);
            }

            return previous;
        }

        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            //lList.Push(9);
            //lList.Push(8);
            //lList.Push(7);
            lList.Push(6);
            lList.Push(5);
            lList.Push(4);
            lList.Push(3);
            lList.Push(2);
            lList.Push(1);

            Console.WriteLine("Origional Linked List is : ");
            lList.PrintLinkedList();

            lList.head =  lList.ReverseLinkedListInGivenGroupSize(lList.head , 2);

            Console.WriteLine("\nModified Linked List is : ");
            lList.PrintLinkedList();

            Console.ReadKey();
        }
    }
}
