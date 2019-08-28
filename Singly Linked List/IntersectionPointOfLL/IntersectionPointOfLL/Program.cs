using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionPointOfLL
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
        Node head1;
        Node head2;

        public LinkedList()
        {
            head1 = null;
            head2 = null;
        }

        public int GetNode()
        {
            int c1 = GetCount(head1);
            int c2 = GetCount(head2);
            int d;

            if (c1 > c2)
            {
                d = c1 - c2;
                return GetIntersectionPoint(d, head1, head2);
            }
            else
            {
                d = c2 - c1;
                return GetIntersectionPoint(d, head2, head1);
            }
            
        }

        public int GetIntersectionPoint(int d, Node node1, Node node2)
        {
            Node current1 = node1;
            Node current2 = node2;

            for (int i = 0; i < d; i++)
            {
                if (current1 == null)
                {
                    return -1;
                }
                current1 = current1.next;
            }

            while (current1 != null && current2 != null)
            {
                if (current1.data == current2.data)
                {
                    return current1.data;
                }
                current1 = current1.next;
                current2 = current2.next;
            }
            return -1;
        }

        public int GetCount(Node node)
        {
            Node current = node;
            int count = 0;

            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            // creating first linked list 
            list.head1 = new Node(3);
            list.head1.next = new Node(6);
            list.head1.next.next = new Node(15);
            list.head1.next.next.next = new Node(15);
            list.head1.next.next.next.next = new Node(30);

            // creating second linked list 
            list.head2 = new Node(10);
            list.head2.next = new Node(15);
            list.head2.next.next = new Node(30);

            Console.WriteLine("The node of Intersection is : " + list.GetNode());

            Console.ReadKey();
        }
    }
}
