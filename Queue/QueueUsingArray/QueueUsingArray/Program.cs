using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingArray
{
    class Queue
    {
        private int[] element;
        private int front;
        private int rear;
        private int max;

        public Queue(int size)
        {
            element = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void Enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                element[++rear] = item;
            }
        }

        public int Dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty.");
                return -1;
            }
            else
            {
                Console.WriteLine(element[front] + " dequeued from queue.");
                int p = element[front++];
                Console.WriteLine();
                Console.WriteLine("Front item is {0}", element[front]);
                Console.WriteLine("Rear item is {0}", element[rear]);
                return p;
            }
        }

        public void printQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                for (int i = 0; i <= rear; i++)
                {
                    Console.WriteLine(element[i] + " is enqueued to queue");
                }
            }
        }
        static void Main(string[] args)
        {
            Queue q = new Queue(5);
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.printQueue();
            q.Dequeue();
            Console.ReadKey();
        }
    }
}
