using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[] array = { 1,2,3,4};

            int sum = size * (size + 1) / 2;
            int newSum = 0;


            foreach (int item in array)
            {
                newSum += item;
            }

            int result = sum - newSum;

            Console.WriteLine("Missing Number : " + result);

            Console.ReadKey();
        }
    }
}
