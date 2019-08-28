using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteNodeAtGivenPosition
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

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void DeleteNodeAtGivenPosition(int position)
        {
            if (head == null)
            {
                return;
            }

            Node temp = head;

            if (position == 0) // Delete Head Node
            {
                head = head.next;   
            }

            int i = 1;
            
            while (i < position-1 && temp != null)
            {
                temp = temp.next;
                i++;
            }

            if (temp == null || temp.next == null)
            {
                return;
            }

            temp.next = temp.next.next; 
        }

        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            lList.Push(5);
            lList.Push(4);
            lList.Push(3);
            lList.Push(2);
            lList.Push(1);

            Console.Write("Origional Linked List is : ");
            lList.PrintList();

            lList.DeleteNodeAtGivenPosition(5);
            Console.Write("\nModified Linked List is : ");
            lList.PrintList();

            Console.ReadKey();

        }
    }
}
