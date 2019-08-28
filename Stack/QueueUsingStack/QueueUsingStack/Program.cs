using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingStack
{
    class QueueUsingStack
    {
        public class Queue
        {
            public Stack<int> stack1;
            public Stack<int> stack2;
        }

        public static void Push(Stack<int> top_ref, int new_data)
        {
            top_ref.Push(new_data);
        }

        public static int Pop(Stack<int> top_ref)
        {
            if (top_ref.Count == 0)
            {
                Console.WriteLine("Stack Underflow.");
                Environment.Exit(0);
            }
            return top_ref.Pop();
        }

        public static void EnQueue(Queue q, int x)
        {
            Push(q.stack1, x);
        }

        public static int DeQueue(Queue q)
        {
            int x;

            if (q.stack1.Count == 0 && q.stack2.Count == 0)
            {
                Console.WriteLine("Queue is Empty.");
                Environment.Exit(0);
            }

            if (q.stack2.Count == 0)
            {
                while (q.stack1.Count != 0)
                {
                    x = Pop(q.stack1);
                    Push(q.stack2, x);
                }
            }

            x = Pop(q.stack2);
            return x;
        }

        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.stack1 = new Stack<int>();
            q.stack2 = new Stack<int>();

            EnQueue(q, 1);
            EnQueue(q, 2);
            EnQueue(q, 3);

            Console.Write(DeQueue(q) + " ");
            Console.Write(DeQueue(q) + " ");
            Console.Write(DeQueue(q) + " ");

            Console.ReadKey();
        }
    }
}
