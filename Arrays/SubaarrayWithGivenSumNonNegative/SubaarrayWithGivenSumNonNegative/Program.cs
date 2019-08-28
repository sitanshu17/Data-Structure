using System;

namespace SubaarrayWithGivenSumNonNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 15, 2, 4, 8, 9, 5, 10, 23 };

            int sum = 23;

            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                int current_sum = array[i];
                for (int j = i+1; j <= length; j++)
                {
                    if (current_sum == sum)
                    {
                        Console.WriteLine("Sum found between " + i + " and " + (j-1));
                    }
                    if (current_sum > sum || j == length)
                    {
                        break;
                    }
                    current_sum += array[j];
                }
            }
            Console.ReadKey();
        }
    }
}
