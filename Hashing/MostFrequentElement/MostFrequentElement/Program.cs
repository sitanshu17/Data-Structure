using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 2, 1, 3, 2, 1,2,2,2 };
            int result = Program.MostFrequentElementInAnArray(arr);
            Console.WriteLine("most Frequent Element is : " + result);
            Console.ReadKey();
        }

        public static int MostFrequentElementInAnArray(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int item in arr)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 1);
                }
                else
                {
                    int frequency = dict[item];
                    frequency++;
                    dict[item] = frequency;
                }
            }

            //Find Maximum Frequency
            dict.OrderBy(x => x.Value);
            int i = 17;

            return 0;
        }
    }
}
