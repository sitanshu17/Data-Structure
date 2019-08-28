using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGreaterElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {11,13,21,3};
            NextGreaterElement(array);
            Console.ReadKey();
        }

        public static void NextGreaterElement(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int ge = -1;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] > array[i])
                    {
                        ge = array[j];
                        break;
                    }
                }
                Console.WriteLine("NGE for " + array[i] + " is " + ge);
            }
        }

        public static void NextGreaterElementUsingStack(int[] array)
        {
            int i = 0;
            Stack st = new Stack();
            st.top = -1;
            int element, next;

            st.Push(array[0]);

            for (i = 1; i < array.Length; i++)
            {
                next = array[i];

                if (st.IsEmpty == false)
                {
                    element = st.Pop();

                    while (element < next)
                    {
                        Console.WriteLine(element + " -----> " + next);
                        if (st.IsEmpty == true)
                        {
                            break;
                        }
                        element = st.Pop();
                    }

                    if (element > next)
                    {
                        st.Push(element);
                    }
                }
                st.Push(next);
            }

            while (st.IsEmpty == false)
            {
                element = st.Pop();
                next = -1;
                Console.WriteLine(element + " -----> " + next);
            }
        }

        public class Stack
        {
            public int top;
            public int[] items = new int[100];

            public virtual void Push(int x)
            {
                if (top == 99)
                {
                    Console.WriteLine("Stack is full.");
                }
                else
                {
                    items[++top] = x;
                }
            }

            public virtual int Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack UnderFlow.");
                    return -1;
                }
                else
                {
                    int element = items[top];
                    top--;
                    return element;
                }
            }

            public virtual bool IsEmpty
            {
                get { return (top == -1) ? true : false;}
            }
        }
    }
}
