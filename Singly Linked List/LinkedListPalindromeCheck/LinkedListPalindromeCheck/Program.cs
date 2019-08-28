using System;
using System.Collections.Generic;

namespace LinkedListPalindromeCheck
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

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
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

        public void LinkedListPalindromeCheck()
        {
            if (head == null)
            {
                return;
            }

            Stack<int> st = new Stack<int>();
            bool isPalindrome = true;
            Node temp = head;

            while (temp != null)
            {
                st.Push(temp.data);
                temp = temp.next;
            }

            temp = head;

            while (temp != null)
            {
                int stackData = st.Pop();
                if (stackData != temp.data)
                {
                    isPalindrome = false;
                    Console.WriteLine("\nThe Linked list is not Palindrome.");
                    break;
                }
                temp = temp.next;
            }
            if (isPalindrome)
            {
                Console.WriteLine("\nThe Linked List is Palindrome.");
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList lList = new LinkedList();
            lList.Push(6);
            lList.Push(2);
            lList.Push(3);
            lList.Push(2);
            lList.Push(1);

            Console.WriteLine("Linked List is : ");
            lList.PrintList();

            lList.LinkedListPalindromeCheck();

            Console.ReadKey();
        }
    }
}
