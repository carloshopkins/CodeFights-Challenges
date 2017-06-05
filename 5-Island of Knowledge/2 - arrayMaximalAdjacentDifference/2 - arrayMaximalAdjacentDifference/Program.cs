using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___arrayMaximalAdjacentDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 2, 4, 1, 0 };
            Console.WriteLine("Expected: 3 | Result: " + arrayMaximalAdjacentDifference(test));
        }
        public static int arrayMaximalAdjacentDifference(int[] arr)
        {
            var result = 0;
            for (var i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] - arr[i + 1]) > result || (arr[i] - arr[i + 1]) * -1 > result)
                {
                    if ((arr[i] - arr[i + 1]) < 0)
                        result = (arr[i] - arr[i + 1]) * -1;
                    else
                        result = (arr[i] - arr[i + 1]);
                }
            }
            return result;
        }
    }
}
