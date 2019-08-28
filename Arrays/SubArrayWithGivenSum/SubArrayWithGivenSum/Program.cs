using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArrayWithGivenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 15, 2, 4, 8, 9, 5, 10, 23 };
            int sum = 23;
            Program.BasicMethod(arr, sum);
            Program.EfficientSolution(arr, sum);
            Console.ReadKey();
        }

        // Could not understand the solution. Need to do this once more.
        public static void EfficientSolution(int[] arr, int sum)
        {
            int currentSum = arr[0];
            int start = 0;

            for (int i = 1; i <= arr.Length; i++)
            {
                if (currentSum > sum)
                {
                    currentSum = currentSum - arr[start];
                    start++;
                }

                if (currentSum == sum)
                {
                    Console.WriteLine("Sum found between " + start + " and " + i);
                    return;
                }

                if (i < arr.Length)
                {
                    currentSum = currentSum + arr[i];
                }
            }

            Console.WriteLine("No Subarray found.");
        }

        public static void BasicMethod(int[] arr, int sum)
        {
            int result = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                result = arr[i];
                for (int j = i+1; j < arr.Length-1; j++)
                {
                    result = result + arr[j];
                    if (result == sum)
                    {
                        Console.WriteLine("Subarray found between " + i + " and " + j);
                    }
                }
            }
        }
    }
}
