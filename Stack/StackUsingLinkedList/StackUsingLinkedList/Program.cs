using System;

namespace StackUsingLinkedList
{
    class StackAsLinkedList
    {
        StackNode root;

        public class StackNode
        {
            public int data;
            public StackNode next;
            public StackNode(int data)
            {
                this.data = data;
            }
        }

        public bool IsEmpty()
        {
            if (root != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Push(int data)
        {
            StackNode newNode = new StackNode(data);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                StackNode temp = root;
                root = newNode;
                newNode.next = temp;
            }
             
            Console.WriteLine(data + " pushed into the stack.");
        }

        public int Pop()
        {
            int popped = int.MinValue;
            if (root == null)
            {
                Console.WriteLine("Stack is Empty."); 
            }
            else
            {
                popped = root.data;
                root = root.next;
            }
            Console.WriteLine(popped + " is popped out from Stack.");
            return popped;
        }

        public int Peek()
        {
            int Peeked = int.MinValue;
            if (root == null)
            {
                Console.WriteLine("Stack is Empty.");
            }
            else
            {
                Peeked = root.data;
            }
            Console.WriteLine(Peeked + " peeked from Stack.");
            return Peeked;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StackAsLinkedList sll = new StackAsLinkedList();

            sll.Push(10);
            sll.Push(20);
            sll.Push(30);

            sll.Pop();
            sll.Peek();

            Console.ReadKey();

        }
    }
}
