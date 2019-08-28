using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySubsetOfAnotherArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 11, 1, 13, 21, 3, 7 };
            int[] arr2 = { 11, 3, 7, 1};
            bool result = Program.CheckSubset(arr1, arr2);

            if (result)
            {
                Console.WriteLine("Subset.");
            }
            else
            {
                Console.WriteLine("Not a Subset.");
            }
            Console.ReadKey();
        }

        public static bool CheckSubset(int[] arr1, int[] arr2)
        {
            HashSet<int> hashSet = new HashSet<int>();

            foreach (int item in arr1)
            {
                if (!hashSet.Contains(item))
                {
                    hashSet.Add(item);
                }
            }

            foreach (int item in arr2)
            {
                if (!hashSet.Contains(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
