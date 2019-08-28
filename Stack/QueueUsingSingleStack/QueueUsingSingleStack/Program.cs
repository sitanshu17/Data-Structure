using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingSingleStack
{
    

    class QueueUsingSingleStack
    {
        public class Queue
        {
            public Stack<int> stack1;
        }

        public static void Push(Stack<int> top_ref, int new_data)
        {
            top_ref.Push(new_data);
        }

        public static int Pop(Stack<int> top_ref)
        {
            if (top_ref == null)
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
            int x, res = 0;

            if (q.stack1.Count == 0)
            {
                Console.WriteLine("Q is Empty.");
                Environment.Exit(0);
            }

            else if (q.stack1.Count == 1)
            {
                return Pop(q.stack1);
            }
            else
            {
                x = Pop(q.stack1);
                res = DeQueue(q);
                Push(q.stack1, x);
                return res;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.stack1 = new Stack<int>();

            EnQueue(q, 1);
            EnQueue(q, 2);
            EnQueue(q, 3);

            Console.WriteLine(DeQueue(q) + " ");
            Console.WriteLine(DeQueue(q) + " ");
            Console.WriteLine(DeQueue(q) + " ");

            Console.ReadKey();
        }
    }
}
