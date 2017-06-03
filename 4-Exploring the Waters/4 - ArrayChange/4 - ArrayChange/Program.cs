using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___ArrayChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { -1000, 0, -2, 0 };
            int[] testArr2 = { 1, 1, 1 };
            int[] testArr3 = { 2, 3, 3, 5, 5, 5, 4, 12, 12, 10, 15 };

            Console.WriteLine("Expected: 5 | Result: " + arrayChange(testArr));
            Console.WriteLine("Expected: 3 | Result: " + arrayChange(testArr2));
            Console.WriteLine("Expected: 13 | Result: " + arrayChange(testArr3));
        }
        public static int arrayChange(int[] inputArray)
        {
            var count = 0;
            for (var i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] <= inputArray[i - 1])
                {
                    count += inputArray[i - 1] + 1 - inputArray[i];
                    inputArray[i] = inputArray[i - 1] + 1;
                }
            }
            return count;
        }
    }
}
