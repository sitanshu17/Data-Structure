using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLoopInLinkedList
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

        public void LengthOfLoop(Node slow)
        {
            Node temp = slow;
            int count = 1;
            while (temp.next != slow)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("\nLength of Loop : " + count);
        }

        public void DetechLoopInLinkedList()
        {
            Node slow = head;
            Node fast = head;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    Console.WriteLine("\nLoop Detected");
                    LengthOfLoop(slow);
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            lList.Push(20);
            lList.Push(4);
            lList.Push(15);
            lList.Push(10);

            Console.WriteLine("Linked List is : ");
            lList.PrintList();

            lList.head.next.next.next.next = lList.head;
            lList.DetechLoopInLinkedList();
            Console.ReadKey();
        }
    }
}
