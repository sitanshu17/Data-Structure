using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMiddleElement
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

        public void GetMiddleElement()
        {
            Node slow = head;
            Node fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            Console.WriteLine("\nMiddle Element of the Linked List is " + slow.data);
        }

        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            lList.Push(5);
            lList.Push(4);
            lList.Push(3);
            lList.Push(2);            
            lList.Push(1);

            Console.Write("Linked List is : ");
            lList.PrintList();
            lList.GetMiddleElement();

            Console.ReadKey();
        }
    }
}
