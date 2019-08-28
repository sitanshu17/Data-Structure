using System;

namespace ReverseWordsOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "I can crack any coding interview";

            string[] testArray = test.Split(" ");

            for (int i = testArray.Length-1; i >= 0; i--)
            {
                Console.Write(testArray[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
