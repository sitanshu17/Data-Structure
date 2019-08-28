using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaderElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 16, 17, 4, 3, 5, 2 };

            int max = arr[arr.Length - 1];
            Console.Write(max + " ");

            for (int i = arr.Length-2; i >= 0; i--)
            {
                if (arr[i] > max)
                {
                    Console.Write(arr[i] + " ");
                    max = arr[i];
                }
            }
            Console.ReadKey();
        }
    }
}
