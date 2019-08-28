using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetNodeOfLinkedList
{
    public class Node
    {
        public int data;
        public Node Next;

        public Node(int data)
        {
            this.data = data;
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
                temp = temp.Next;
            }
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public int GetNodeOfLinkedList(int Position)
        {
            Node temp = head;
            for (int i = 0; i < Position-1 && temp != null; i++)
            {
                temp = temp.Next;
            }
            if (temp == null)
            {
                return 0;
            }
            return temp.data;
        }

        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            lList.Push(5);
            lList.Push(4);
            lList.Push(3);
            lList.Push(2);
            lList.Push(1);

            Console.WriteLine("Linked List is : ");
            lList.PrintList();

            int position = 9;
            Console.WriteLine("\nGet Data at " + position);
            Console.WriteLine(lList.GetNodeOfLinkedList(position)); 

            Console.ReadKey();
        }
    }
}
