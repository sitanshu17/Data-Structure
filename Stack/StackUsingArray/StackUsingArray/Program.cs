using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingArray
{
    class Stack
    {
        private int[] element;
        private int top;
        private int max;
        public Stack(int size)
        {
            element = new int[size];
            top = -1;
            max = size;
        }

        public void Push(int item)
        {
            if (top == max-1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                element[++top] = item;
            }
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty.");
                return -1;
            }
            else
            {
                Console.WriteLine("{0} is popped from Stack.", element[top]);
                return element[top--];
            }
        }

        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine();
                return element[top];
            }
        }

        public void PrintStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty.");
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("{0} pushed into stack.", element[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Stack st = new Stack(5);
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.PrintStack();
            st.Pop();
            Console.ReadKey();
        }
    }
}
