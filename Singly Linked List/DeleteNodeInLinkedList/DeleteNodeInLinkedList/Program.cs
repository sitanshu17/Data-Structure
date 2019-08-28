using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteNodeInLinkedList
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

        public void InsertNode(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void DeleteNode(int key)
        {
            if (head.data == key)
            {
                head = head.next;
                return;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    if (temp.next.data == key)
                    {
                        temp.next = temp.next.next;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            lList.InsertNode(5);
            lList.InsertNode(4);
            lList.InsertNode(3);
            lList.InsertNode(2);
            lList.InsertNode(1);

            Console.WriteLine("Origional Linked List : ");
            lList.PrintList();

            Console.WriteLine("\nModified Linked List : ");
            lList.DeleteNode(5);
            lList.PrintList();

            Console.ReadKey();
        }
    }
}
