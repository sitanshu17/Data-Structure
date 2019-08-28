using System;

namespace ReveerseLinkedListRecursive
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

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public Node PrintList(Node node)
        {
            Console.WriteLine(node.data);
            if (node.next == null)
            {
                return null;
                //return node;
            }

            return PrintList(node.next);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList lList = new LinkedList();
            lList.Push(3);
            lList.Push(2);
            lList.Push(1);

            Console.WriteLine("Print Linked List : ");
            Node result = lList.PrintList(lList.head);

            Console.ReadKey();
        }
    }
}
