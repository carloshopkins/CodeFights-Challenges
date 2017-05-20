using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentElementsProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray =  { 3, 6, -2, -5, 7, 3 };
            Console.WriteLine(AdjacentProduct(inputArray));
        }
        public static int AdjacentProduct(int[] inputArr)
        {
            int result = inputArr[0] * inputArr[1];
            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                if (inputArr[i] * inputArr[i + 1] > result)
                    result = inputArr[i] * inputArr[i + 1];
            }
            return result;
        }
    }
}
